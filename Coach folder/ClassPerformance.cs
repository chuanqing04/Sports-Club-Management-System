using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    internal class ClassPerformance
    {
        private string connectionString;

        public ClassPerformance(string connectionString)
        {
            this.connectionString = connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
        }

        public void PopulateEmailComboBox(ComboBox comboBox)
        {
            string query = "SELECT email FROM Member";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string email = reader["email"].ToString();
                        comboBox.Items.Add(email);
                    }
                }
            }
        }

        public void PopulatePerformanceComboBox(ComboBox comboBox)
        {
            comboBox.Items.AddRange(new object[] { "Bad", "Good", "Great" });
        }

        public string GetPerformance(string email)
        {
            string performance = "";
            string query = "SELECT performance FROM Member WHERE email = @Email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    performance = result.ToString();
                }
            }
            return performance;
        }

        public bool UpdatePerformance(string email, string newPerformance)
        {
            string query = "UPDATE Member SET performance = @Performance WHERE email = @Email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Performance", newPerformance);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
