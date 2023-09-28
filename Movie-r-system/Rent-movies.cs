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
    public partial class Rent_movies : Form
    {
        string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=DME.5;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        int rowID;
        public Rent_movies()
        {
            InitializeComponent();
        }
        private DataTable GetData()
        {
            var table = new DataTable();
            var connection = new SqlConnection(connectionString);

            try
            {
                using (connection)
                {
                    string mySelectQuery = "SELECT * FROM Movie";
                    var cmd = new SqlCommand(mySelectQuery, connection);
                    connection.Open();
                    var reader = cmd.ExecuteReader();
                    table.Load(reader);

                    table = table.Rows
                    .Cast<DataRow>()
                    .Where(row => !row.ItemArray.All(field => field is DBNull || string.IsNullOrWhiteSpace(field as string)))
                    .CopyToDataTable();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            string premere1 = "False";
            string avaliable1 = "False";

            if (titletxt.Text == "" || directortxt.Text == "" || genretxt.Text == "" || actorstxt.Text == "")
            {
                MessageBox.Show("Please fill in all the fields");
            }
            if (premere.Checked == true)
            {
                premere1 = "True";
            }
            if (avalible.Checked == true)
            {
                avaliable1 = "True";
            }

            string query = "INSERT INTO Movie (Title, Director,Actors,Genre,Premiere,Available) VALUES (@Title, @Director,@Actors,@Genre,@Premiere,@Available)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", titletxt.Text);
            command.Parameters.AddWithValue("@Director", directortxt.Text);
            command.Parameters.AddWithValue("@Actors", actorstxt.Text);
            command.Parameters.AddWithValue("@Genre", genretxt.Text);
            command.Parameters.AddWithValue("@Premiere", premere1);
            command.Parameters.AddWithValue("@Available", avaliable1);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Movie added");
                dataGridView1.DataSource = GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }




        }

        private void Rent_movies_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string premere1 = "False";
            string avaliable1 = "False";

            if (titletxt.Text == "" || directortxt.Text == "" || genretxt.Text == "" || actorstxt.Text == "")
            {
                MessageBox.Show("Please fill in all the fields");
            }
            if (premere.Checked == true)
            {
                premere1 = "True";
            }
            if (avalible.Checked == true)
            {
                avaliable1 = "True";
            }

            string query = "Update Movie set Title=@Title,Director=@Director,Actors=@Actors,Genre=@Genre,Premiere=@Premiere,Available=@Available where Movie_id=@Movie_id";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", titletxt.Text);
            command.Parameters.AddWithValue("@Director", directortxt.Text);
            command.Parameters.AddWithValue("@Actors", actorstxt.Text);
            command.Parameters.AddWithValue("@Genre", genretxt.Text);
            command.Parameters.AddWithValue("@Premiere", premere1);
            command.Parameters.AddWithValue("@Available", avaliable1);
            command.Parameters.AddWithValue("@Movie_id", rowID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Movie Updated");
                dataGridView1.DataSource = GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }




        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
        
            titletxt.Text = row.Cells[1].Value.ToString();
            directortxt.Text = row.Cells[2].Value.ToString();
            actorstxt.Text = row.Cells[3].Value.ToString();
            genretxt.Text = row.Cells[4].Value.ToString();
            if (row.Cells[5].Value.ToString() == "True")
            {
                premere.Checked = true;
            }
            else
            {
                premere.Checked = false;
            }
            if (row.Cells[6].Value.ToString() == "True")
            {
                avalible.Checked = true;
            }
            else
            {
                avalible.Checked = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string query = "Delete from Movie where Movie_id=@Movie_id";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Movie_id", rowID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Movie Deleted");
                dataGridView1.DataSource = GetData();
              
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
