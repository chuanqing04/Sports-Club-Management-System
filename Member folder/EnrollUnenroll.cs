using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehehe
{
    public partial class enrollform : Form
    {
        
        public enrollform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberHome.instance.tc.Text = button1.Text;
            fee.Text = "RM 20";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MemberHome.instance.tc.Text = "unenrolled";
            fee.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberHome.instance.tc.Text = button2.Text;
            fee.Text = "RM 40";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberHome.instance.tc.Text = button3.Text;
            fee.Text = "RM 60";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
