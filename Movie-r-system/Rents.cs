using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Movie_r_system
{
    public partial class Rents : Form
    {
        string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=DME.5;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        int rowID;
        public Rents()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rents_Load(object sender, EventArgs e)
        {
            
                dataGridView1.DataSource = GetData();
            
            
            
            string query = "SELECT * FROM Movie";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    string title = reader.GetString(0);
                //    movie.Items.Add(title);
                //}
                var table = new DataTable();
                table.Load(reader);
                movie.DataSource = table;
                movie.DisplayMember = "Title";
                movie.ValueMember = "Movie_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query2 = "SELECT * FROM Users";
            SqlConnection con2 = new SqlConnection(connectionString);
            SqlCommand cmd2 = new SqlCommand(query2, con2);
            SqlDataReader reader2;
            try
            {
                con2.Open();
                reader2 = cmd2.ExecuteReader();
                //while (reader2.Read())
                //{
                //    string name = reader2.GetString(0);
                //    user.Items.Add(name);
                //}
                var table = new DataTable();
                table.Load(reader2);
                user.DataSource = table;
                user.DisplayMember = "Name";
                user.ValueMember = "User_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            rowID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            rentdate.Text = row.Cells[1].Value.ToString();
            returndate.Text = row.Cells[2].Value.ToString();
            price.Text = row.Cells[3].Value.ToString();
            user.Text = row.Cells[4].Value.ToString();
            movie.Text = row.Cells[5].Value.ToString();


        }
        private DataTable GetData()
        {
            var table = new DataTable();
            var connection = new SqlConnection(connectionString);

            try
            {
                using (connection)
                {
                    string mySelectQuery = "SELECT Rented.Rent_date,Rented.Return_date, Rented.Price , Name, Title FROM Rented " +
                        "INNER JOIN Users ON Rented.User_id = Users.User_id " +
                        "INNER JOIN Movie ON Rented.Movie_id = Movie.Movie_id";
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
            
            if(rentdate.Text == "" || returndate.Text == "" || price.Text == "" || user.Text == "" || movie.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                string query = "INSERT INTO Rented (Rent_date, Return_date, Price, User_id, Movie_id) VALUES (@RentDate, @ReturnDate, @Price, @UserID, @MovieID)";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RentDate", rentdate.Text);
                cmd.Parameters.AddWithValue("@ReturnDate", returndate.Text);
                cmd.Parameters.AddWithValue("@Price", price.Text);
                cmd.Parameters.AddWithValue("@UserID", user.SelectedValue);
                cmd.Parameters.AddWithValue("@MovieID", movie.SelectedValue);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie rented successfully");
                    dataGridView1.DataSource = GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rentdate.Text == "" || returndate.Text == "" || price.Text == "" || user.Text == "" || movie.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string query = "UPDATE Rented SET Rent_date = @RentDate, Return_date = @ReturnDate, Price = @Price,Name = @Name, Title = @Title WHERE Rent_id = @Rental_id";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Rental_id", rowID);
            cmd.Parameters.AddWithValue("@RentDate", rentdate.Text);
            cmd.Parameters.AddWithValue("@ReturnDate", returndate.Text);
            cmd.Parameters.AddWithValue("@Price", price.Text);
            cmd.Parameters.AddWithValue("@Name", user.Text);
            cmd.Parameters.AddWithValue("@Title", movie.Text);
            try
            {
                
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rental updated");
                dataGridView1.DataSource = GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

       
    }
}
