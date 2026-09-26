using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ClassEditUser
    {
        private string email;
        private string password;
        private string userName;
        private string additionalInfo;
        private string userRole;
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString());

        public ClassEditUser(string email, string password, string userName, string additionalInfo, string userRole)
        {
            this.email = email;
            this.password = password;
            this.userName = userName;
            this.additionalInfo = additionalInfo;
            this.userRole = userRole;
        }

        public string edituser(string userRole)
        {
            string status;
            SqlTransaction transaction = null;
            try
            {
                    con.Open();
                    transaction = con.BeginTransaction();

                    // Insert data into the user table
                    SqlCommand cmdUser = new SqlCommand("UPDATE users SET password = @pwd, username = @uname WHERE email = @em", con, transaction);
                    cmdUser.Parameters.AddWithValue("@em", email);
                    cmdUser.Parameters.AddWithValue("@pwd", password);
                    cmdUser.Parameters.AddWithValue("@uname", userName);
                    cmdUser.ExecuteNonQuery();

                    // If the user is a coach, insert data into the coach table
                    if (userRole == "coach")
                    {
                        string[] info = additionalInfo.Split('|');
                        string training = info[0];
                        string salary = info[1];

                        SqlCommand cmdCoach = new SqlCommand("UPDATE coach SET traininglevel = @training, salary = @salary WHERE email = @em", con, transaction);
                        cmdCoach.Parameters.AddWithValue("@em", email);
                        cmdCoach.Parameters.AddWithValue("@training", training);
                        cmdCoach.Parameters.AddWithValue("@salary", salary);
                        cmdCoach.ExecuteNonQuery();
                    }
                    // If the user is a member, insert data into the member table
                    else if (userRole == "member")
                    {
                        SqlCommand cmdMember = new SqlCommand("UPDATE member SET traininglevel = @training WHERE email = @em", con, transaction);
                        cmdMember.Parameters.AddWithValue("@em", email);
                        cmdMember.Parameters.AddWithValue("@training", additionalInfo);
                        cmdMember.ExecuteNonQuery();
                    }
                    // If the user is a manager, insert data into the manager table
                    else if (userRole == "manager")
                    {
                        SqlCommand cmdManager = new SqlCommand("UPDATE manager SET salary = @salary WHERE email = @em", con, transaction);
                        cmdManager.Parameters.AddWithValue("@em", email);
                        cmdManager.Parameters.AddWithValue("@salary", additionalInfo);
                        cmdManager.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    status = "Update Successful";
                
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                status = "Update failed: " + ex.Message;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return status;
        }


        public string DeleteUser(string email, string userRole)
        {
            string status;
            SqlTransaction transaction = null;
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString()))
                {
                    con.Open();
                    transaction = con.BeginTransaction();

                    SqlCommand cmdDeleteUser = new SqlCommand("DELETE FROM users WHERE email = @email", con, transaction);
                    cmdDeleteUser.Parameters.AddWithValue("@email", email);
                    cmdDeleteUser.ExecuteNonQuery();

                    // Additional deletion based on user role
                    if (userRole != "admin")
                    {
                        string command = $"DELETE FROM {userRole} WHERE email = @email";
                        Debug.WriteLine("SQL Command: " + command); // Output SQL command to the Output window for debugging
                        SqlCommand cmdDeleteRole = new SqlCommand(command, con, transaction);
                        cmdDeleteRole.Parameters.AddWithValue("@email", email);
                        cmdDeleteRole.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    status = "User deleted successfully";
                }
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        // Handle rollback exception
                        status = "Error rolling back transaction: " + exRollback.Message;
                    }
                }
                status = "Error deleting user: " + ex.Message;
            }
            return status;
        }
    }
}