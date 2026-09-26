using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class TrainingSchedule : Form
    {
        public TrainingSchedule()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddTbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddT obj1 = new AddT();
            obj1.ShowDialog();
            obj1 = null;
            this.Show();
        }

        private void EditTbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditT obj1 = new EditT();
            obj1.ShowDialog();
            obj1 = null;
            this.Show();
        }
    }
}
