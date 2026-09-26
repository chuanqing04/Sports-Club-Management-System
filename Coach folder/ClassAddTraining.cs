using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment
{
    class ClassAddTraining
    {
        private DateTime Date, STime, ETime;
        private string TrainingLevel;

        public ClassAddTraining(DateTime Date, DateTime STime, DateTime ETime, string TrainingLevel)
        {
            this.Date = Date;
            this.STime = STime;
            this.ETime = ETime;
            this.TrainingLevel = TrainingLevel;
        }

        public string addTraining(SqlConnection connection)
        {
            if (ScheduleExist(connection))
            {
                return "Schedule already exists";
            }
            else
            {
                string query = "INSERT INTO Schedule (Date, StartTime, EndTime, Duration, Level) VALUES (@Date, @StartTime, @EndTime, @Duration, @Level)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@StartTime", STime);
                command.Parameters.AddWithValue("@EndTime", ETime);
                TimeSpan duration = ETime - STime;
                string Duration = string.Format("{0} hour {1} minute {2} second", (int)duration.TotalHours, duration.Minutes, duration.Seconds);
                command.Parameters.AddWithValue("@Duration", Duration);
                command.Parameters.AddWithValue("@Level", TrainingLevel);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 ? "Schedule added successfully" : "No data inserted";
            }
        }

        private bool ScheduleExist(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM Schedule WHERE CONVERT(DATE, Date) = @Date AND CONVERT(TIME, StartTime) = @StartTime";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Date", Date.Date);
                command.Parameters.AddWithValue("@StartTime", STime.TimeOfDay);
                int existingSchedulesCount = (int)command.ExecuteScalar();
                return existingSchedulesCount > 0;
            }
        }
    }
}
