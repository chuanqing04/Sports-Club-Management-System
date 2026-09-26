using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class EditT : Form
    {
        private string connectionString;
        public EditT()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            DisplayTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ScheduleID, Date, StartTime, EndTime, Duration, Level FROM Schedule";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool DeleteSchedule(int scheduleID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            string query = "DELETE FROM Schedule WHERE ScheduleID = @ScheduleID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ScheduleID", scheduleID);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error deleting schedule: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        private void RefreshSchedule()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            string query = "SELECT ScheduleID, Date, StartTime, EndTime, Duration, Level FROM Schedule";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error loading data into DataGridView: " + ex.Message);
                    }
                }
                dataGridView1.DataSource = dataTable;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Deletebtn_Click_1(object sender, EventArgs e)
        {
            int scheduleID;
            if (int.TryParse(textBox1.Text, out scheduleID))
            {
                bool success = DeleteSchedule(scheduleID);
                if (success)
                {
                    MessageBox.Show("Schedule deleted successfully.");
                    RefreshSchedule();
                }
                else
                {
                    MessageBox.Show("Failed to delete schedule. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Schedule ID.");
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            int selectedScheduleID = int.Parse(textBox1.Text);
            using (Edit obj1 = new Edit(selectedScheduleID))
            {
                obj1.ShowDialog();
            }
            this.Show();
            RefreshSchedule();
        }
    }
}
