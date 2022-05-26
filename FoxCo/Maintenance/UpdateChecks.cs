using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace FoxCo.Maintenance
{
    public partial class UpdateChecks : Form
    {
        private String dbConnection;

        public UpdateChecks()
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

        //This fills the Aircraft ComboBox with the AirCraft ID's that are in the database
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

        //This returns the user to the Maintanence Menu
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            MaintMenu menu = new MaintMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }

        // This checks to ensure that the selected item in the ComboBox is an aircraft and if it isn't, then it displays an error
        //If it is, it sets the Aircraft Label to the selected AIrcraft
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxAircraft.SelectedIndex >= 0)
            {
                
                controlVisible();

                labelAircraft.Text = comboBoxAircraft.SelectedItem.ToString();
            }
            else
                MessageBox.Show("Please select an Aircraft");
        }

        //When the user selects a valid aircraft it makes the labels for the checks visible and the update buttons
        //as well as hiding the Aircraft ComboBox
        private void controlVisible()
        {
            buttonSelect.Visible = false;
            comboBoxAircraft.Visible = false;
            labelAcheck.Visible = true;
            labelBcheck.Visible = true;
            labelCcheck.Visible = true;
            labelDcheck.Visible = true;
            labelSelAircraft.Visible = true;
            labelAircraft.Visible = true;
            buttonReturn.Visible = true;
            buttonUpdateACheck.Visible = true;
            buttonUpdateBCheck.Visible = true;
            buttonUpdateCCheck.Visible = true;
            buttonUpdateDCheck.Visible = true;
        }

        //This takes the current date and passes it to the updateCheck along with the type check in order to update the Maintenance Check
        private void buttonUpdateACheck_Click(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString();
            String[] value = date.Split(' ');
            String format = "dd/MM/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime newdate = DateTime.ParseExact(value[0], format, provider);
            updateCheck(newdate, labelAircraft.Text, "aCheck");
        }
        //This takes the current date and passes it to the updateCheck along with the type check in order to update the Maintenance Check
        private void buttonUpdateBCheck_Click(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString();
            String[] value = date.Split(' ');
            String format = "dd/MM/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime newdate = DateTime.ParseExact(value[0], format, provider);
            updateCheck(newdate, labelAircraft.Text, "bCheck");
        }
        //This takes the current date and passes it to the updateCheck along with the type check in order to update the Maintenance Check
        private void buttonUpdateCCheck_Click(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString();
            String[] value = date.Split(' ');
            String format = "dd/MM/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime newdate = DateTime.ParseExact(value[0], format, provider);
            updateCheck(newdate, labelAircraft.Text, "cCheck");
        }
        //This takes the current date and passes it to the updateCheck along with the type check in order to update the Maintenance Check
        private void buttonUpdateDCheck_Click(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString();
            String[] value = date.Split(' ');
            String format = "dd/MM/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime newdate = DateTime.ParseExact(value[0], format, provider);
            updateCheck(newdate, labelAircraft.Text, "dCheck");
        }

        //This takes the check that has been selected and sets hte SQL string to the required one for button selected
        //And then it uses this to update the database with the current date for the specified maintenance check
        private void updateCheck(DateTime date, String aircraftID, String checkType)
        {
            String sql = "";
            switch (checkType)
            {
                case "aCheck":
                    sql = "UPDATE Aircraft set aCheck = @date WHERE aircraftID = @aircraftID";
                    break;
                case "bCheck":
                    sql = "UPDATE Aircraft set bCheck = @date WHERE aircraftID = @aircraftID";
                    break;
                case "cCheck":
                    sql = "UPDATE Aircraft set cCheck = @date WHERE aircraftID = @aircraftID";
                    break;
                case "dCheck":
                    sql = "UPDATE Aircraft set dCheck = @date WHERE aircraftID = @aircraftID";
                    break;
            }

            

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@aircraftID", aircraftID);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The check was updated successfully");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                try
                {
                    con.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }


    }
}
