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
    public partial class add : Form
    {

        // inicijalizacija string varijabli
        private string title;
        private string keywords;
        private string summary;
        private string body;
        private string insertstring;
        private bool pass = true;

        public add()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            // čitanje iz textboxova
            title = titletextbox.Text;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Your article must have a title");
                pass = false;
            }

            keywords = keywordstextbox.Text;
            if (string.IsNullOrWhiteSpace(keywords))
            {
                MessageBox.Show("You need to have at least one keyword");
                pass = false;
            }

            summary = summarytextbox.Text;

            body = bodytextbox.Text;
            if (string.IsNullOrWhiteSpace(body))
            {
                MessageBox.Show("Articles with no body text not allowed");
                pass = false;
            }

            if (pass) {
                insertstring = "insert into documents values ('" + title + "', '" + keywords + "', '" + summary + "', '" + body + "');";

                // spajanje na bazu
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres");
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(insertstring, conn);

                try
                {
                    System.Diagnostics.Debug.Write(insertstring);
                    cmd.ExecuteNonQuery();
                    messagelabel.Text = "Succesfully added";
                    messagelabel.Visible = true;

                }
                catch (Exception ex)
                {
                    messagelabel.Text = "Error: unsuccesful";
                    messagelabel.Visible = true;
                }

                conn.Close();
            }


        }
    }
}
