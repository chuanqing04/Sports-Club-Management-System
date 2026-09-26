using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment
{
    public partial class CoachMenu : Form
    {
        private string email;
        public CoachMenu(string email)
        {
            InitializeComponent();
            this.email = email;
            labelemail.Text = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainingSchedule obj1 = new TrainingSchedule();
            obj1.ShowDialog();
            obj1 = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rec obj1 = new Rec();
            obj1.ShowDialog();
            obj1 = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perform obj1 = new Perform();
            obj1.ShowDialog(); 
            obj1 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeeDue obj1 = new FeeDue();
            obj1.ShowDialog();
            obj1 = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfUpdateCoach obj1 = new ProfUpdateCoach(email);
            obj1.ShowDialog();
            obj1 = null;
            this.Show();
        }
    }
}
