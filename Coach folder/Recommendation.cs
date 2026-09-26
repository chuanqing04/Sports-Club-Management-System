using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Assignment
{
    public partial class Rec : Form
    {
        public Rec()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateRecommendation()
        {
            try
            {
                string recommendationText = richTextBox1.Text;
                string connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Recommendation (Rec) VALUES (@Recommendation)";
                        command.Parameters.AddWithValue("@Recommendation", recommendationText);
                        command.CommandTimeout = 120;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recommendation updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No records updated.");
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            UpdateRecommendation();
        }
    }
}
