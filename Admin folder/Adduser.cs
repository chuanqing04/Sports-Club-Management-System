using System;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            mtbtraining.Visible = false;
            mtbsalary.Visible = false;
            mtbtraining.Clear();
            mtbsalary.Clear();
        }

        private void rbManager_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            mtbsalary.Visible=true;
            label5.Visible=false;
            mtbtraining.Visible = false;
            mtbtraining.Clear();
            mtbsalary.Clear();
        }

        private void rbCoach_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible=true;
            mtbtraining.Visible = true;
            mtbsalary.Visible=true;
            mtbtraining.Clear();
            mtbsalary.Clear();
        }

        private void rbMember_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible = false;
            mtbsalary.Visible = false;
            mtbtraining.Visible = true;
            mtbtraining.Clear();
            mtbsalary.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbconfirm.Text != tbpassword.Text)
            {
                MessageBox.Show("Password confirmation error.");
            }
            else
            {
                string email = tbemail.Text;
                string password = tbpassword.Text;
                string username = tbusername.Text;
                string additionalInfo = "";

                if (rbCoach.Checked)
                {
                    additionalInfo = mtbtraining.Text + "|" + mtbsalary.Text;
                }
                else if (rbMember.Checked)
                {
                    additionalInfo = mtbtraining.Text;
                }
                else if (rbManager.Checked)
                {
                    additionalInfo = mtbsalary.Text;
                }

                Add_user addUser = new Add_user(email, password, username, additionalInfo);
                string userRole = rbAdmin.Checked ? "admin" : rbMember.Checked ? "member" : rbCoach.Checked ? "coach" : "manager";
                MessageBox.Show(addUser.adduser(userRole));
                tbemail.Clear();
                tbpassword.Clear();
                tbconfirm.Clear();
                tbusername.Clear();
                mtbtraining.Clear();
                mtbsalary.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbemail.Clear();
            tbpassword.Clear();
            tbconfirm.Clear();
            tbusername.Clear();
            mtbtraining.Clear();
            mtbsalary.Clear();
        }

    }
}
