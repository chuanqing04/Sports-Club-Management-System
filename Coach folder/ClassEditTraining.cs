using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNamespace
{
    public class ScheduleEditor
    {
        private int scheduleID;

        public ScheduleEditor(int scheduleID)
        {
            this.scheduleID = scheduleID;
        }

        public void UpdateSchedule(DateTime newDate, DateTime newStartTime, DateTime newEndTime, string newLevel)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Schedule SET Date = @Date, StartTime = @StartTime, EndTime = @EndTime, Level = @Level WHERE ScheduleID = @ScheduleID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", newDate);
                command.Parameters.AddWithValue("@StartTime", newStartTime);
                command.Parameters.AddWithValue("@EndTime", newEndTime);
                command.Parameters.AddWithValue("@Level", newLevel);
                command.Parameters.AddWithValue("@ScheduleID", scheduleID);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Schedule updated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to update schedule.");
                }
            }
        }
    }
}
