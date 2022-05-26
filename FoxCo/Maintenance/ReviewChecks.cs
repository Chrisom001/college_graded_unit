using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo.Maintenance
{
    public partial class ReviewChecks : Form
    {
        private String dbConnection;

        public ReviewChecks()
        {
            InitializeComponent();
            startup();
        }

        private void startup()
        {
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            ImportantCode test = new ImportantCode();
            String version = test.versionNumber();
            labelVersion.Text = version;
            dbConnection = test.dbConnection();
            fillAircraft();
        }

        //This fills the Aircraft comboBox with the aircraft ID's from the database
        private void fillAircraft()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT aircraftID FROM Aircraft";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxAircraft.Items.Add(reader["aircraftID"]);
                    }
                    reader.Close();
                }
                con.Close();
            }
        }
        //This returns the user to the Maintenance Menu
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            MaintMenu menu = new MaintMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }
        //This takes the user to the form to update checks
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateChecks update = new UpdateChecks();
            this.Close();
            this.Dispose();
            update.ShowDialog();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            String dateString;
            String[] values;
            //This checks if the selected aircraft has an index of 0 or higher, if not they haven't selected an aircraft and it will return an error
            if(comboBoxAircraft.SelectedIndex >= 0)
            {
                //If they select a valid aircraft, it uses the item visibility function
                //as well as search the database for the checks from the Aircraft table
                //and then filling the labels with this information
                itemVisibility();
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
                String query = "SELECT type, aCheck, bCheck, cCheck, dCheck FROM Aircraft WHERE aircraftID = @aircraftID";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@aircraftID", comboBoxAircraft.SelectedItem.ToString());
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dateString = dateFix(reader["aCheck"].ToString(), reader["bCheck"].ToString(), reader["cCheck"].ToString(), reader["dCheck"].ToString());
                            values = dateString.Split(' ');
                            labelAcheckInfo.Text = values[0];
                            labelBcheckInfo.Text = values[1];
                            labelCcheckInfo.Text = values[2];
                            labelDcheckInfo.Text = values[3];
                            labelAirTypeInfo.Text = reader["type"].ToString();
                        }
                        reader.Close();
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an Aircraft from the list");
            }

            
        }
        //When a valid aircraft is selected, it unhides the labels for the checks and the update button
        private void itemVisibility()
        {
            labelAcheck.Visible = true;
            labelAcheckInfo.Visible = true;
            labelBcheck.Visible = true;
            labelBcheckInfo.Visible = true;
            labelCcheck.Visible = true;
            labelCcheckInfo.Visible = true;
            labelDcheck.Visible = true;
            labelDcheckInfo.Visible = true;
            labelAircraftType.Visible = true;
            labelAirTypeInfo.Visible = true;
            buttonUpdate.Visible = true;
        }
        //This takes the date given from the database and then puts them from a US format to the UK format using an array
        //and splitting it before putting it back together again correctly
        private String dateFix(String aCheck, String bCheck, String cCheck, String dCheck)
        {
            String[] values;
            String output = "";
            values = aCheck.Split(' ');
            output += values[0];
            output += " ";
            values = bCheck.Split(' ');
            output += values[0];
            output += " ";
            values = cCheck.Split(' ');
            output += values[0];
            output += " ";
            values = dCheck.Split(' ');
            output += values[0];
            output += " ";
            return output;
        }
    }
}
