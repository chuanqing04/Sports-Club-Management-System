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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    public partial class AdminHome : Form
    {
        public static string name;
        private const string Suggestion = "Suggestion";
        private const string Income = "Income";
        private const string Competition = "Competition";

        public AdminHome()
        {
            InitializeComponent();
        }

        public AdminHome(String n)
        {
            InitializeComponent();
            name = n;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblidentity.Text = $"Welcome, {name}";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Adduser ad = new Adduser();
            ad.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchEmail = tbSearchemail.Text.Trim();
            SearchUser(searchEmail);
        }

        private void SearchUser(string email)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE email = @email", con);
                    cmd.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbluserRole.Text = reader["role"].ToString();
                        lblemail.Text = reader["email"].ToString();
                        lblpassword.Text = reader["password"].ToString();
                        lblusername.Text = reader["username"].ToString();

                        string userRole = reader["role"].ToString();

                        if (userRole == "coach" || userRole == "member" || userRole == "manager")
                        {
                            DisplayAdditionalInfo(userRole, email);
                        }
                        else
                        {
                            lbltraininglevel.Text = null;
                            lblsalary.Text = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayAdditionalInfo(string userRole, string email)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString()))
                {
                    con.Open();
                    string tableName = ""; // Initialize table name
                    switch (userRole)
                    {
                        case "coach":
                            tableName = "coach";
                            break;
                        case "member":
                            tableName = "member";
                            break;
                        case "manager":
                            tableName = "manager";
                            break;
                        default:
                            break;
                    }
                    if (!string.IsNullOrEmpty(tableName))
                    {
                        string sqlQuery = $"SELECT * FROM {tableName} WHERE email = @email";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.Parameters.AddWithValue("@email", email);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            try
                            {
                                lbltraininglevel.Text = reader["traininglevel"].ToString();
                            }
                            catch
                            {
                                lbltraininglevel.Text = null;
                            }
                            try
                            {
                                lblsalary.Text = reader["salary"].ToString();
                            }
                            catch
                            {
                                lblsalary.Text = null;
                            }
                        }
                        else
                        {
                            lbltraininglevel.Text = null;
                            lblsalary.Text = null;
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string email = lblemail.Text;
            string password = lblpassword.Text;
            string username = lblusername.Text;
            string userRole = lbluserRole.Text;
            string trainingLevel = lbltraininglevel.Text;
            string salary = lblsalary.Text;
            clearFields();

            Edituser editUser = new Edituser(email, password, username, trainingLevel, salary, userRole,true);
            editUser.ShowDialog();
        }

        private void clearFields()
        {
            lbluserRole.Text = null;
            lblemail.Text = null;
            lblpassword.Text = null;
            lblusername.Text = null;
            lbltraininglevel.Text = null;
            lblsalary.Text = null;
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE email = @name", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbluserRole.Text = reader["role"].ToString();
                        lblemail.Text = reader["email"].ToString();
                        lblpassword.Text = reader["password"].ToString();
                        lblusername.Text = reader["username"].ToString();
                        lbluserRole.Text = reader["role"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            string email = lblemail.Text;
            string password = lblpassword.Text;
            string username = lblusername.Text;
            string userRole = lbluserRole.Text;
            clearFields();
            Edituser editUserForm = new Edituser(email, password, username, "","", userRole,false);
            editUserForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnviewR_Click(object sender, EventArgs e)
        {
            View vS = new View(Suggestion);
            vS.ShowDialog();
        }

        private void btnviewI_Click_2(object sender, EventArgs e)
        {
            View vI = new View(Income);
            vI.ShowDialog();
        }

        private void btnviewC_Click(object sender, EventArgs e)
        {
            View vC = new View(Competition);
            vC.ShowDialog();
        }
    }
}