using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Movie_r_system
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=DME.5;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rent_movies rent_Movies = new Rent_movies();
            rent_Movies.Show();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();

        }
    }
}
