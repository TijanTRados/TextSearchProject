using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMIBP_text_search_project
{
    public partial class Initial : Form
    {
        public Initial()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var add = new add();
            add.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            var search = new search();
            search.Show();
        }

        private void analysis_Click(object sender, EventArgs e)
        {
            var analisys = new analisys();
            analisys.Show();
        }
    }
}
