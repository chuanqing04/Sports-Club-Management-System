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
    public partial class MemberHome : Form
    {
        public static MemberHome instance;
        public Label tc;
        public Label n;
        public Label ID;
        public MemberHome()
        {
            InitializeComponent();
            instance = this;
            tc = trainningclass;
            n = name;
            ID = id;
        }

        private void enroll_unenroll_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            enrollform f2 = new enrollform();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateprofile f3 = new updateprofile();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void schedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            f4 = null;
            this.Show();
        }
    }
}
