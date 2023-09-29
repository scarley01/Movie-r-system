using System;
using System.Collections;
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
    public partial class Users : Form
    {
        string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=DME.5;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        int rowID;
        public Users()
        {
            InitializeComponent();
            
        }
        private void Users_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            name.Text = row.Cells[1].Value.ToString();
            address.Text = row.Cells[2].Value.ToString();
            phone.Text = row.Cells[3].Value.ToString();
            email.Text = row.Cells[4].Value.ToString();
            zip.Text = row.Cells[5].Value.ToString();


        }
        private DataTable GetData()
        {
            var table = new DataTable();
            var connection = new SqlConnection(connectionString);

            try
            {
                using (connection)
                {
                    string mySelectQuery = "SELECT * FROM Users";
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
    

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (name.Text == "" || address.Text == "" || phone.Text == "" || email.Text == "" || zip.Text == "")
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }


            string myInsertQuery = "INSERT INTO Users (Name, Address, Phone, Email, Zip) Values (@Name, @Address, @Phone, @Email, @Zip)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(myInsertQuery, connection);


            command.Parameters.AddWithValue("@Name", name.Text);
            command.Parameters.AddWithValue("@Address", address.Text);
            command.Parameters.AddWithValue("@Phone", phone.Text);
            command.Parameters.AddWithValue("@Email", email.Text);
            command.Parameters.AddWithValue("@Zip", zip.Text);




            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("User added");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if(address.Text == "" || phone.Text == "" || email.Text == "" || zip.Text == "")
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }
            string myUpdateQuery = "UPDATE Users SET Name = @Name, Address = @Address, Phone = @Phone, Email = @Email, Zip = @Zip WHERE User_id = @User_id";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(myUpdateQuery, connection);
            command.Parameters.AddWithValue("@User_id", rowID);
            command.Parameters.AddWithValue("@Name", name.Text);
            command.Parameters.AddWithValue("@Address", address.Text);
            command.Parameters.AddWithValue("@Phone", phone.Text);
            command.Parameters.AddWithValue("@Email", email.Text);
            command.Parameters.AddWithValue("@Zip", zip.Text);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("User updated");
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

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Users WHERE User_id = @User_id";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@User_id", rowID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("User Deleted");
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
    }
}
