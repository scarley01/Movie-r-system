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
    public partial class NotAvailableMovies : Form
    {
        string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=DME.5;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public NotAvailableMovies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotAvailableMovies_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Movie where Available = 'False'";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    var table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("No movies found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
