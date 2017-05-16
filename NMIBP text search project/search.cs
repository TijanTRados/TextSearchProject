using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace NMIBP_text_search_project
{
    public partial class search : Form
    {
        private string searchstring;

        public search()
        {
            InitializeComponent();
        }

        private void search_buttonclick(object sender, EventArgs e)
        {
            searchstring = searchbox.Text;
            string originalstring = searchstring;
            string sqlcode2 = "INSERT INTO analisys VALUES ('" + originalstring+"')";

            // sending search text for search analysis
            NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres");
            conn2.Open();

            NpgsqlCommand cmd2 = new NpgsqlCommand(sqlcode2, conn2);
            cmd2.ExecuteNonQuery();

            conn2.Close();

            if (optionone.Checked)
            {

            string finalstring = "'";
            bool inside = false; //tells if inside brackets

            // Handles double spaces
            searchstring = searchstring.Replace("   ", " ");
            searchstring = searchstring.Replace("  ", " ");
            searchstring = searchstring.Replace("\"", "(");

            // Converts search input into tsquery input pattern text
            for (int i = 0; i < searchstring.Length; i++)
            {
                if (searchstring[i] == '(' && !inside)
                {
                    inside = true;
                    finalstring = finalstring + "( ";

                }
                else if (searchstring[i] == '(' && inside)
                {
                    inside = false;
                    finalstring = finalstring + " )";
                }
                else if (searchstring[i] == ' ' && inside)
                {
                    finalstring = finalstring + " & ";
                }
                else if (searchstring[i] == ' ' && !inside)
                {
                    if (andradio.Checked) finalstring = finalstring + " § ";
                    if (orradio.Checked) finalstring = finalstring + " | ";
                }
                else finalstring = finalstring + searchstring[i];

            }

            finalstring = finalstring + "'";
            //System.Diagnostics.Debug.Write(finalstring);

            string[] phrases;
            string sqlcode = "";

            //creating sql query with AND operator
            if (andradio.Checked) {
                phrases = finalstring.Split('§');

                finalstring = finalstring.Replace("§", "&");


                sqlcode = "SELECT ts_headline(title, to_tsquery('english'," + finalstring + ")) as name,\r\n          ts_headline(body, to_tsquery('english', " + finalstring + ")),\r\n          ts_rank(vector, to_tsquery('english', " + finalstring + "), 1) rank \r\nFROM documents\r\nWHERE vector @@ to_tsquery('english', " + phrases[0];
                for (int i = 1; i < phrases.Length; i++)
                {

                    sqlcode = sqlcode + "')\r\nAND vector @@ to_tsquery('english', '" + phrases[i];
                }
                sqlcode = sqlcode + ") \r\nORDER BY rank DESC LIMIT 10";
            }

            else //creating sql query with OR operator
            {
                phrases = finalstring.Split('|');

                sqlcode = "SELECT ts_headline(title, to_tsquery('english'," + finalstring + ")) as name,\r\n          ts_headline(body, to_tsquery('english', " + finalstring + ")),\r\n          ts_rank(vector, to_tsquery('english', " + finalstring + "), 1) rank \r\nFROM documents\r\nWHERE vector @@ to_tsquery('english', " + phrases[0];
                for (int i = 1; i < phrases.Length; i++)
                {

                    sqlcode = sqlcode + "')\r\nOR vector @@ to_tsquery('english', '" + phrases[i];
                }
                sqlcode = sqlcode + ") \r\nORDER BY rank DESC LIMIT 10";
            }

            sqlbox.Text = sqlcode;


            // connecting to sql database
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres");
            conn.Open();

            sqlcode = sqlcode.Replace("\r\n", " ");

            NpgsqlCommand cmd = new NpgsqlCommand(sqlcode, conn);
            NpgsqlDataReader result = cmd.ExecuteReader(); //executing query

            int number = 0;
            string resultstring = "<html><body style=\"font - family:arial; font-size:12; \"> ";

            //catching result form database
            while (result.Read())
            {
                number++; //result count
                resultstring = resultstring +"<p>"+ number+". " + result[0]+": "+result[1]+" ["+result[2]+"]"+"</p>";
            }

            string info = "Number of documents retrieved: " + number;
            resultgroup.Text = info;

            resultstring = resultstring + "</body></html>";

            //creating result as text in webbrowser tool
            resultcontainer.DocumentText = resultstring;

            
            conn.Close();
        }
            else if (optiontwo.Checked)
            {
                /*
                string sqlcode = "";

                //creating sql query for fuzzy search
                sqlcode = "SELECT title,\r\n          similarity (lower('"+searchstring+"'), lower(title)) sim\r\nFROM documents\r\nWHERE lower('"+searchstring+"') % lower(title)\r\nORDER BY sim DESC";

                //show fuzzy sql query in sql text box
                sqlbox.Text = sqlcode;

                // connecting to sql database
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres");
                conn.Open();

                sqlcode = sqlcode.Replace("\r\n", " ");

                NpgsqlCommand cmd = new NpgsqlCommand(sqlcode, conn);
                NpgsqlDataReader result = cmd.ExecuteReader(); //executing query

                int number = 0;
                string resultstring = "<html><body style=\"font - family:arial; font-size:12; \"> ";

                //catching result form database
                while (result.Read())
                {
                    number++; //result count
                    resultstring = resultstring + "<p>" + number + ". " + result[0] + " [" + result[1] + "]" + "</p>";
                }

                string info = "Number of documents retrieved: " + number;
                resultgroup.Text = info;

                resultstring = resultstring + "</body></html>";

                //creating result as text in webbrowser tool
                resultcontainer.DocumentText = resultstring;

                conn.Close();*/

                string finalstring = "'";
                
                bool inside = false; //tells if inside brackets

                // Handles double spaces
                searchstring = searchstring.Replace("   ", " ");
                searchstring = searchstring.Replace("  ", " ");
                searchstring = searchstring.Replace("\"", "(");

                // Converts search input into tsquery input pattern text
                for (int i = 0; i < searchstring.Length; i++)
                {
                    if (searchstring[i] == '(' && !inside)
                    {
                        inside = true;
                        finalstring = finalstring + "( ";

                    }
                    else if (searchstring[i] == '(' && inside)
                    {
                        inside = false;
                        finalstring = finalstring + " )";
                    }
                    else if (searchstring[i] == ' ' && inside)
                    {
                        finalstring = finalstring + " & ";
                    }
                    else if (searchstring[i] == ' ' && !inside)
                    {
                        if (andradio.Checked) finalstring = finalstring + " § ";
                        if (orradio.Checked) finalstring = finalstring + " | ";
                    }
                    else finalstring = finalstring + searchstring[i];

                }

                finalstring = finalstring + "'";
                //System.Diagnostics.Debug.Write(finalstring);

                string[] phrases;
                string sqlcode = "";

                //creating sql query with AND operator
                if (andradio.Checked)
                {
                    phrases = finalstring.Split('§');

                    finalstring = finalstring.Replace("§", "&");


                    sqlcode = "SELECT ts_headline(title, to_tsquery('english'," + finalstring + ")) as name,\r\n          ts_headline(body, to_tsquery('english', " + finalstring + ")),\r\n          similarity (lower('" + originalstring + "'), lower(title)) sim\r\nFROM documents\r\nWHERE title % " + phrases[0].Replace("&", "").Replace("(","").Replace(")","").Trim();
                    for (int i = 1; i < phrases.Length; i++)
                    {

                        sqlcode = sqlcode + "'\r\nAND title % '" + phrases[i].Replace("&", "").Replace("(", "").Replace(")", "").Trim();
                    }
                    sqlcode = sqlcode + "\r\nORDER BY sim DESC";
                }

                else //creating sql query with OR operator
                {
                    phrases = finalstring.Split('|');

                    sqlcode = "SELECT ts_headline(title, to_tsquery('english'," + finalstring + ")) as name,\r\n          ts_headline(body, to_tsquery('english', " + finalstring + ")),\r\n          similarity (lower('" + originalstring + "'), lower(title)) sim\r\nFROM documents\r\nWHERE title % " + phrases[0].Replace("&", "").Replace("(", "").Replace(")", "").Trim();
                    for (int i = 1; i < phrases.Length; i++)
                    {

                        sqlcode = sqlcode + "'\r\nOR title % '" + phrases[i].Replace("&", "").Replace("(", "").Replace(")", "").Trim();
                    }
                    sqlcode = sqlcode + "\r\nORDER BY sim DESC";
                }

                sqlbox.Text = sqlcode;


                // connecting to sql database
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres");
                conn.Open();

                sqlcode = sqlcode.Replace("\r\n", " ");

                NpgsqlCommand cmd = new NpgsqlCommand(sqlcode, conn);
                NpgsqlDataReader result = cmd.ExecuteReader(); //executing query

                int number = 0;
                string resultstring = "<html><body style=\"font - family:arial; font-size:12; \"> ";

                //catching result form database
                while (result.Read())
                {
                    number++; //result count
                    resultstring = resultstring + "<p>" + number + ". " + result[0] + ": " + result[1] + " [" + result[2] + "]" + "</p>";
                }

                string info = "Number of documents retrieved: " + number;
                resultgroup.Text = info;

                resultstring = resultstring + "</body></html>";

                //creating result as text in webbrowser tool
                resultcontainer.DocumentText = resultstring;

                conn.Close();
            }
        }

        private void orradio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
