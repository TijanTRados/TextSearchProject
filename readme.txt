1. U izradi ovog projekta koristio sam pgAdmin III grafièko suèelje za rad sa PostgreSQL-om na lokalnom raèunalu.
   Koristim bazu zvanu "documents" u koju se spremaju èlanci ili tekstovi koji sadrže svoj naziv, kljuène rijeèi, kratki sadržaj i tijelo.
   Baza je sama po sebi spremna za pretraživanje.
   Kroz Visual Studio napravio sam Desktop aplikaciju koja pristupa bazi te je vrlo jednostavna i intuitivna. Koristim 4 razlièita prozora: poèetni, prozor za upis, pretragu i analizu povijesti pretrage.
   Input je tekst, output je tekst za SQL naredbeni dio, a webbrowser box za rezultat. 

2. Program se pokreæe dvoklikom na "NMIBP text search project.sln" koji se nalazi u direktoriju "NMIBP text search project" uz prethodno instaliran Visual Studio. Otvara se rješenje programa, a sama se aplikacija pokreæe pritiskom na "Run".

3. Shema baze

::::::::::::::::::::::::::::::::::::::::::Baza koja sadrži podatke:
CREATE TABLE public.documents
(
  title text,
  keyword text,
  summary text,
  body text,
  vector tsvector
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.documents
  OWNER TO postgres;

:::::::::::::::::::::::::::::::::::::::::::Baza koja sadrži analizu podataka:
CREATE TABLE public.analisys
(
  query text,
  date_time timestamp without time zone DEFAULT now()
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.analisys
  OWNER TO postgres;

:::::::::::::::::::::::::::::::::::::::::::Triger funkcija za stvaranje vektora pri unosu istance:
CREATE OR REPLACE FUNCTION public.tsvector_create()
  RETURNS trigger AS
$BODY$
BEGIN
    NEW.vector := 	setweight(to_tsvector('english', NEW.title), 'A') ||
			setweight(to_tsvector('english', NEW.keyword), 'B') ||
			setweight(to_tsvector('english', NEW.summary), 'C') ||
			setweight(to_tsvector('english', NEW.body), 'D');

    RETURN NEW;
END
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION public.tsvector_create()
  OWNER TO postgres;

::::::::::::::::::::::::::::::::::::::::::::Triger za pozivanje triger funkcije:
CREATE TRIGGER insert_trigger
  BEFORE INSERT OR UPDATE
  ON public.documents
  FOR EACH ROW
  EXECUTE PROCEDURE public.tsvector_create();

::::::::::::::::::::::::::::::::::::::::::::Fuzzy index:
CREATE INDEX fuzzyindex
  ON public.documents
  USING btree
  (title COLLATE pg_catalog."default");

:::::::::::::::::::::::::::::::::::::::::::Morphology index:
CREATE INDEX morphindex
  ON public.documents
  USING gin
  (vector);

:::::::::::::::::::::::::::::::::::::::::::Trigram index:
CREATE INDEX trgmindex
  ON public.documents
  USING gin
  (title COLLATE pg_catalog."default" gin_trgm_ops);

