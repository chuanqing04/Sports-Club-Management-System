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
using System.Xml.Linq;

namespace Assignment
{
    public partial class ProfUpdateCoach : Form
    {
        public string email;
        private string connectionString;

        public ProfUpdateCoach(string email)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            this.email = email;

        }

        private void OldTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CNewTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string newUsername = NameTBox.Text;
            string newPassword = NewTBox.Text;
            string confirmNewPassword = CNewTBox.Text;

            // Check if any of the fields are empty
            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if new password and confirm password match
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirm new password do not match. Please try again.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Update the username and password in the Users table
                    string query = "UPDATE Users SET username = @NewUsername, password = @NewPassword WHERE email = @Email";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewUsername", newUsername);
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update profile.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.Close();
        }
    }
}
