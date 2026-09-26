using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AddT : Form
    {
        public AddT()
        {
            InitializeComponent();
            ResetAllDateTimePickers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ResetAllDateTimePickers()
        {
            DatePicker.Value = DatePicker.Value.Date;
            STimePicker.Value = DateTime.Today;
            ETimePicker.Value = DateTime.Today;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DateTime Date, STime, ETime;
            Date = DatePicker.Value;
            STime = STimePicker.Value;
            ETime = ETimePicker.Value;
            string TrainingLevel = lvlText.Text;
            if (DatePicker.Value == null)
            {
                MessageBox.Show("Please select a date.");
                return;
            }
            if (STimePicker.Value == null)
            {
                MessageBox.Show("Please select a start time.");
                return;
            }
            if (ETimePicker.Value == null)
            {
                MessageBox.Show("Please select an end time.");
                return;
            }
            if (lvlText.Text != "Beginner" && lvlText.Text != "Intermediate" && lvlText.Text != "Advanced")
            {
                MessageBox.Show("Please enter one of the Training level");
                return;
            }
            ClassAddTraining AddTraining = new ClassAddTraining(Date, STime, ETime, TrainingLevel);

            string connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    ClassAddTraining AddTrainingLevel = new ClassAddTraining(Date, STime, ETime, TrainingLevel);
                    string result = AddTrainingLevel.addTraining(connection);
                    MessageBox.Show(result);
                }
            }
            ResetAllDateTimePickers();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void STimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lvlText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
