using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class Edit : Form
    {
        private int selectedScheduleID;
        public Edit(int selectedScheduleID)
        {
            InitializeComponent();
            this.selectedScheduleID = selectedScheduleID;
        }

        private int GetSelectedScheduleID()
        {
            return selectedScheduleID;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            DateTime newDate = DatePicker.Value;
            DateTime newStartTime = STimePicker.Value;
            DateTime newEndTime = ETimePicker.Value;
            string newLevel = lvlText.Text;
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

            int selectedScheduleID = GetSelectedScheduleID();
            ScheduleEditor editor = new ScheduleEditor(selectedScheduleID);
            editor.UpdateSchedule(newDate, newStartTime, newEndTime, newLevel);
            MessageBox.Show("Edit successful.");
            this.Close();
        }
    }
}
