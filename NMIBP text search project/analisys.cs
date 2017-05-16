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
    public partial class analisys : Form
    {
        public analisys()
        {
            InitializeComponent();
        }

        private void analyse_click(object sender, EventArgs e)
        {
            DateTime datumod = datefrom.Value;
            DateTime datumdo = dateto.Value;
            TimeSpan razlika = datumdo - datumod;

            if (daybutton.Checked)
            {

                int razlikaint = razlika.Days;
                razlikaint++;

                //creating sql string to send
                string sqlquery = "CREATE TEMP TABLE dan (dan int); \r\n";

                for (int i = 0; i < razlikaint; i++)
                {
                    sqlquery = sqlquery + "INSERT INTO dan VALUES (" + (datumod.Day + i).ToString() + "); \r\n";
                }

                sqlquery = sqlquery + "\r\nSELECT * \r\nFROM crosstab \r\n      ('SELECT CAST(query as char(50)) AS upit, \r\n       CAST(extract(day from date_time) AS int) as dan, \r\n       CAST(count(*) AS int) AS brojupita \r\n       FROM analisys \r\n       GROUP BY upit, dan \r\n       ORDER BY upit, dan', \r\n       'SELECT CAST(dan as INT) FROM dan ORDER BY dan') \r\nAS pivotTable (query Char(50)";

                for (int i = 0; i < razlikaint; i++)
                {
                    sqlquery = sqlquery + ", Day" + (datumod.Day + i).ToString() + (datumod.Month).ToString() + (datumod.Year).ToString() + " INT";
                }

                sqlquery = sqlquery + ") \r\nORDER BY query";

                sqlbox.Text = sqlquery;

                sqlquery = sqlquery.Replace("\r\n", "");

                //connection to database
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres");
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(sqlquery, conn);
                NpgsqlDataReader result = cmd.ExecuteReader(); //executing query

                //creating html output
                string resultstring = "<html><body><table style=\"font-size:12; font-style: arial; width:100%; border: 1px solid black\"><tr><td>Query</td>";

                for (int i = 0; i < razlikaint; i++)
                {
                    resultstring = resultstring + "<td>Day" + (datumod.Day + i).ToString() + (datumod.Month).ToString() + (datumod.Year).ToString() + "</td>";
                }

                resultstring = resultstring + "</tr>";

                while (result.Read())
                {
                    resultstring = resultstring + "<tr>";
                    for (int i = 0; i < razlikaint + 1; i++)
                    {
                        resultstring = resultstring + "<td>" + result[i].ToString() + "</td>";
                    }
                    resultstring = resultstring + "</tr>";
                }

                resultstring = resultstring + "</table></body></html>";

                //creating result as text in webbrowser tool
                resultcontainer.DocumentText = resultstring;

                conn.Close();
            } else
            {
                int razlikaint = razlika.Days;
                razlikaint++;

                //creating sql string to send
                string sqlquery = "CREATE TEMP TABLE sat (sat int); \r\n";

                for (int i = 0; i < 24; i++)
                {
                    sqlquery = sqlquery + "INSERT INTO sat VALUES (" + i.ToString() + "); \r\n";
                }

                sqlquery = sqlquery + "\r\nSELECT * \r\nFROM crosstab \r\n      ('SELECT CAST(query as char(50)) AS upit, \r\n       CAST(extract(hour from date_time) AS int) as sat, \r\n       CAST(count(*) AS int) AS brojupita \r\n       FROM analisys \r\n       GROUP BY upit, sat \r\n       ORDER BY upit, sat', \r\n       'SELECT CAST(sat as INT) FROM sat ORDER BY sat') \r\nAS pivotTable (query Char(50)";

                for (int i = 0; i < 24; i++)
                {
                    sqlquery = sqlquery + ", Hour" + i.ToString() + " INT";
                }

                sqlquery = sqlquery + ") \r\nORDER BY query";

                sqlbox.Text = sqlquery;

                sqlquery = sqlquery.Replace("\r\n", "");

                //connection to database
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres");
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(sqlquery, conn);
                NpgsqlDataReader result = cmd.ExecuteReader(); //executing query

                //creating html output
                string resultstring = "<html><body><table style=\"font-size:12; font-style: arial; width:100%; border: 1px solid black\"><tr><td>Query</td>";

                for (int i = 0; i < 24; i++)
                {
                    resultstring = resultstring + "<td>Hour" + i.ToString() + "</td>";
                }

                resultstring = resultstring + "</tr>";

                while (result.Read())
                {
                    resultstring = resultstring + "<tr>";
                    for (int i = 0; i < 24; i++)
                    {
                        resultstring = resultstring + "<td>" + result[i].ToString() + "</td>";
                    }
                    resultstring = resultstring + "</tr>";
                }

                resultstring = resultstring + "</table></body></html>";

                //creating result as text in webbrowser tool
                resultcontainer.DocumentText = resultstring;

                conn.Close();
            }

        }
    }
}
