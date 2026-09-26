using System;
using System.Configuration;
using System.Windows.Forms;

namespace Assignment
{
    public partial class View : Form
    {
        private readonly string command;
        private readonly string connectionString;
        private ClassView cv1;

        public View(string command)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            this.command = command;

            switch (command)
            {
                case "Suggestion":
                case "Income":
                case "Recommendation":
                    cv1 = new ClassView(connectionString);
                    cv1.PopulateListBox(lbid, command);
                    break;
                default:
                    MessageBox.Show("Command not supported.");
                    break;
            }
        }

        private void lbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cv1 != null)
                {
                    // Get the selected ID from the list box
                    int selectedId = Convert.ToInt32(lbid.SelectedItem);

                    // Retrieve the suggestion from the database based on the selected ID
                    string suggestion = cv1.GetSuggestionById(selectedId, command);

                    // Display the suggestion in the read-only text box
                    rtbsuggestion.Text = suggestion;
                }
                else
                {
                    MessageBox.Show("Command not supported.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
