using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Edituser : Form
    {
        private string email;
        private string userRole;

        public Edituser(string email, string password, string userName, string trainingLevel, string salary, string userRole, bool showDeleteButton)
        {
            InitializeComponent();

            tbpassword.Text = password;
            tbusername.Text = userName;
            this.email = email;
            this.userRole = userRole;

            if (userRole == "coach")
            {
                lbltraining.Visible = true;
                mtbtraining.Visible = true;
                lblsalary.Visible = true;
                mtbsalary.Visible = true;

                mtbtraining.Text = trainingLevel;
                mtbsalary.Text = salary;
            }
            else if (userRole == "member")
            {
                lbltraining.Visible = true;
                mtbtraining.Visible = true;
                mtbtraining.Text = trainingLevel;
            }
            else if (userRole == "manager")
            {
                lblsalary.Visible = true;
                mtbsalary.Visible = true;
                mtbsalary.Text = salary;
            }
            btndelete.Visible = showDeleteButton;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btncommit_Click(object sender, EventArgs e)
        {
            if (tbconfirm.Text != tbpassword.Text)
            {
                MessageBox.Show("Password confirmation error.");
            }
            else
            {
                string password = tbpassword.Text;
                string username = tbusername.Text;
                string additionalInfo = "";

                if (userRole == "coach")
                {
                    additionalInfo = mtbtraining.Text + "|" + mtbsalary.Text;
                }
                else if (userRole == "member")
                {
                    additionalInfo = mtbtraining.Text;
                }
                else if (userRole == "manager")
                {
                    additionalInfo = mtbsalary.Text;
                }

                try
                {
                    ClassEditUser editUser = new ClassEditUser(email, password, username, additionalInfo, userRole);
                    MessageBox.Show(editUser.edituser(email)); // Show the status returned by the edituser method
                    this.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete this {userRole}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ClassEditUser editUser = new ClassEditUser(email, "", "", "", userRole);
                    string status = editUser.DeleteUser(email, userRole);

                    MessageBox.Show(status);
                    ClearFields();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            tbpassword.Clear();
            tbconfirm.Clear();
            tbusername.Clear();
            mtbtraining.Clear();
            mtbsalary.Clear();
        }
    }
}
    

