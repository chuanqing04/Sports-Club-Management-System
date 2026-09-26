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
using System.Xml;

namespace Assignment
{
    public partial class Perform : Form
    {
        private string connectionString;
        private ClassPerformance recordManager;
        public Perform()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            recordManager = new ClassPerformance(connectionString);
            recordManager.PopulateEmailComboBox(comboBox1);
            recordManager.PopulatePerformanceComboBox(comboBox2);
            DisplayTable();
        }

        private void DisplayTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id, email, performance FROM Member";
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedEmail = comboBox1.SelectedItem.ToString();
                string performance = recordManager.GetPerformance(selectedEmail);
                comboBox2.SelectedItem = performance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedEmail = comboBox1.SelectedItem.ToString();
                string newPerformance = comboBox2.SelectedItem.ToString();
                bool success = recordManager.UpdatePerformance(selectedEmail, newPerformance);
                if (success)
                {
                    MessageBox.Show("Performance record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update performance record.");
                }
            }
            else
            {
                MessageBox.Show("Please select an email from the list.");
            }
            this.Close();
        }
    }
}
