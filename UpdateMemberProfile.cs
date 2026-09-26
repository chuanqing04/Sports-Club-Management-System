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
    public partial class updateprofile : Form
    {
        public static updateprofile instance;
        public TextBox tb1;
        public TextBox tb2;
        public updateprofile()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
            tb2 = textBox2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberHome.instance.n.Text = textBox1.Text;
            MemberHome.instance.ID.Text = textBox2.Text;
            this.Hide();
        }
    }
}
