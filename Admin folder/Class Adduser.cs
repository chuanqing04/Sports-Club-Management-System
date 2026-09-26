using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Add_user
    {
        private string email;
        private string password;
        private string userName;
        private string additionalInfo;
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString());

        public Add_user(string email, string password, string userName, string additionalInfo)
        {
            this.email = email;
            this.password = password;
            this.userName = userName;
            this.additionalInfo = additionalInfo;
        }

        public string adduser(string userRole)
        {
            string status;
            SqlTransaction transaction = null;
            try
            {
                if (Email_Exists(email))
                {
                    status = "Email already exists in database.";
                }
                else
                {
                    con.Open();
                    transaction = con.BeginTransaction();

                    // Insert data into the user table
                    SqlCommand cmdUser = new SqlCommand("INSERT INTO users(email, password, username, role) VALUES(@em, @pwd, @uname, @role)", con, transaction);
                    cmdUser.Parameters.AddWithValue("@em", email);
                    cmdUser.Parameters.AddWithValue("@pwd", password);
                    cmdUser.Parameters.AddWithValue("@uname", userName);
                    cmdUser.Parameters.AddWithValue("@role", userRole);
                    cmdUser.ExecuteNonQuery();

                    // If the user is a coach, insert data into the coach table
                    if (userRole == "coach")
                    {
                        string[] info = additionalInfo.Split('|');
                        string training = info[0];
                        string salary = info[1];

                        SqlCommand cmdCoach = new SqlCommand("INSERT INTO coach(email, traininglevel, salary) VALUES(@em, @training, @salary)", con, transaction);
                        cmdCoach.Parameters.AddWithValue("@em", email);
                        cmdCoach.Parameters.AddWithValue("@training", training);
                        cmdCoach.Parameters.AddWithValue("@salary", salary);
                        cmdCoach.ExecuteNonQuery();
                    }
                    // If the user is a member, insert data into the member table
                    else if (userRole == "member")
                    {
                        SqlCommand cmdMember = new SqlCommand("INSERT INTO member(email, traininglevel) VALUES(@em, @training)", con, transaction);
                        cmdMember.Parameters.AddWithValue("@em", email);
                        cmdMember.Parameters.AddWithValue("@training", additionalInfo);
                        cmdMember.ExecuteNonQuery();
                    }
                    // If the user is a manager, insert data into the manager table
                    else if (userRole == "manager")
                    {
                        SqlCommand cmdManager = new SqlCommand("INSERT INTO manager(email, salary) VALUES(@em, @salary)", con, transaction);
                        cmdManager.Parameters.AddWithValue("@em", email);
                        cmdManager.Parameters.AddWithValue("@salary", additionalInfo);
                        cmdManager.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    status = "Registration Successful";
                }
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                status = "Unable to Register: " + ex.Message;
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

        private bool Email_Exists(string email)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM users WHERE email = @em", con);
                cmd.Parameters.AddWithValue("@em", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}