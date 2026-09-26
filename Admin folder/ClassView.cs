using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public class ClassView
    {
        private readonly string connectionString;

        public ClassView(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void PopulateListBox(ListBox lbid, string command)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(GetQueryForCommand(command), con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<int> ids = new List<int>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        ids.Add(id);
                    }

                    lbid.DataSource = ids;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating list box: " + ex.Message);
            }
        }

        private string GetQueryForCommand(string command)
        {
            switch (command)
            {
                case "Suggestion":
                    return "SELECT Id FROM Suggestion";
                case "Income":
                    return "";
                case "Competition":
                    return "SELECT CompetitonID FROM CompetitionResult";
                default:
                    throw new ArgumentException("Invalid command.");
            }
        }

        public string GetSuggestionById(int id, string command)
        {
            string suggestion = "";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(GetQueryForDetail(command), con);
                    cmd.Parameters.AddWithValue("@id", id);
                    object suggestionObj = cmd.ExecuteScalar();

                    if (suggestionObj != null)
                    {
                        suggestion = suggestionObj.ToString();
                    }
                    else
                    {
                        suggestion = "No suggestion found for the selected ID.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return suggestion;
        }

        private string GetQueryForDetail(string command)
        {
            switch (command)
            {
                case "Suggestion":
                    return "SELECT Suggestion FROM Suggestion WHERE ID = @id";
                case "Income":
                    // Provide the SQL query for Income command
                    return "";
                case "Competition":
                    return "SELECT Result FROM CompetitionResult WHERE CompetitionID = @id";
                default:
                    throw new ArgumentException("Invalid command.");
            }
        }
    }
}