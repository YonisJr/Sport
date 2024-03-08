using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport
{
    public partial class auth : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Database=sport;Username=YonisJr;Password=0907;Port=5432");
        public auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "admin")
            {
                admin ad = new admin();
                ad.Show();
                this.Hide();
            }
            else
            {
                emp ad = new emp();
                ad.Show();
                this.Hide();
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void auth_Load(object sender, EventArgs e)
        {

        }
    }
}
