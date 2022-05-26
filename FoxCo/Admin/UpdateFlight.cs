using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace FoxCo.Admin
{
    public partial class UpdateFlight : Form
    {
        private String dbConnection;
        private int selectedFlight;

        public UpdateFlight()
        {
            InitializeComponent();
            startup();
            fillRoutes();
        }

        public void startup()
        {
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            ImportantCode test = new ImportantCode();
            String version = test.versionNumber();
            labelVersion.Text = version;
            dbConnection = test.dbConnection();
            dateTimePicker1.Value = DateTime.Now;
            fillFlights();
        }

        
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            AdminMenu admin = new AdminMenu();
            this.Close();
            this.Dispose();
            admin.ShowDialog();
        }

        //This takes the flight selected in the combobox and splits it based on date and route information
        //It then starts the hiding sections function
        private void buttonSelectFlight_Click(object sender, EventArgs e)
        {
            if(comboBoxFlights.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flight to update");
            } else
            {
                String selectedOption = comboBoxFlights.SelectedItem.ToString();
                String[] values = selectedOption.Split('-');
                String format = "dd/MM/yyyy";
                CultureInfo provider = CultureInfo.InvariantCulture;
                dateTimePicker1.Value = DateTime.ParseExact(values[3].ToString(), format, provider);
                selectedFlight = Int32.Parse(values[0]);
                aircraftCheck();
                labelOrigRoute.Text = values[1] + " to " + values[2];
                labelOrigDate.Text = values[3];
                hidingSections();
            }
            
        }

        //This pulls the flight that is scheduled to be on a flight and sets the original aircraft label to it's Aircraft ID
        private void aircraftCheck()
        {            
            String aircraftID = "";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT aircraftID FROM Flight where flightID = @flightID";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@flightID", selectedFlight);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        aircraftID = reader["aircraftID"].ToString();
                    }
                    reader.Close();
                }
                con.Close();
            }
            labelOrigAircraft.Text = aircraftID;
        }

        //This hides the select flight options once it's selected and then unhides the labels and comboboxes for the new information
        // to be selected.
        private void hidingSections()
        {
            buttonSelectFlight.Visible = false;
            comboBoxFlights.Visible = false;
            labelFlight.Visible = false;
            labelNewDet.Visible = true;
            labelOrig.Visible = true;
            labelAircraftPick.Visible = true;
            labelRoutePick.Visible = true;
            labelDatePick.Visible = true;
            labelOrigAircraft.Visible = true;
            labelOrigDate.Visible = true;
            labelOrigRoute.Visible = true;
            comboBoxAircraft.Visible = true;
            comboBoxRoutes.Visible = true;
            dateTimePicker1.Visible = true;
            buttonUpdate.Visible = true;
        }

        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int routeID = 0;
            String aircraftID = "";
            
            //This checks to make sure a route is selected, if not it then displays an error
            if (comboBoxRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a route");
            }
            else
            {
                String[] routes = comboBoxRoutes.Items[comboBoxRoutes.SelectedIndex].ToString().Split('-');
                routeID = Int32.Parse(routes[0]);
                //This ensures an aircraft is selected and if not an error is displayed
                if (comboBoxAircraft.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an Aircraft");
                }
                else
                {
                    String[] aircraft = comboBoxAircraft.Items[comboBoxAircraft.SelectedIndex].ToString().Split('-');
                    aircraftID = aircraft[0];
                    //This checks to ensure the range for the selected aircraft is sufficient. If it isn't it displays an error
                    if (!rangeCheck(routeID, aircraftID))
                    {
                        MessageBox.Show("This plane cannot make the journey, Please try selecting another");
                    }
                    else
                    {
                        //THis checks to ensure that the date selected for the flight isn't in the past. If it is, it displays an error
                        if (dateTimePicker1.Value < DateTime.Now)
                        {
                            MessageBox.Show("Please choose a date which isn't in the past!");
                        }
                        else
                        {
                            String date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                            //This checks to ensure the aircraft isn't already scheduled for a flight on this day. If it is, it displays an error
                            if (!checkAlreadyOnFlight(aircraftID, date))
                            {
                                updateFlight(routeID, aircraftID, date);
                                buttonUpdate.Visible = false;
                            }
                                
                            else
                                MessageBox.Show("This plane is already scheduled for a flight on this date, please choose another plane");
                        }

                    }
                }
            }
        }

        //This returns a true value if a plane is already schedueld to be on a flight on the day specified by the user. If it isn't, it returns false.
        private bool checkAlreadyOnFlight(String aircraftID, String date)
        {
            int count = 0;
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "select count(@aircraftID) FROM flight where date= @date AND aircraftID = @aircraftID;";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@aircraftID", aircraftID);
                cmd.Parameters.AddWithValue("@date", date);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                con.Close();
            }

            if (count > 0)
                return true;
            else
                return false;
        }

        //This returns true if the range for the aircraft is sufficient to make a flight (With a 200km buffer). If it isn't sufficient it returns false
        private bool rangeCheck(int route, String aircraft)
        {
            if (planeRange(aircraft) > (routeDistance(route) + 200))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //This gets the distance in km for the route which has been selected by the user and returns it
        private int routeDistance(int route)
        {
            int distance = 0;

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "select distance FROM Route where routeID = @routeID";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@routeID", route);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        distance = Int32.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                con.Close();
            }

            return distance;
        }
        //This gets the range for the plane which was selected by the user and returns it
        private int planeRange(String aircraft)
        {
            int range = 0;

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "select range FROM Aircraft where aircraftID = @aircraftID";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@aircraftID", aircraft);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        range = Int32.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                con.Close();
            }

            return range;
        }

        //This takes the information provided by the user and updates the flight in the database
        private void updateFlight(int routeID, String aircraftID, String date)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");

            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            string sql = "UPDATE Flight set aircraftID = @aircraftID, routeID = @routeID, date = @date WHERE flightID = @flightID";
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@flightID", selectedFlight);
                cmd.Parameters.AddWithValue("@aircraftID", aircraftID);
                cmd.Parameters.AddWithValue("@routeID", routeID);
                cmd.Parameters.AddWithValue("@date", date);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Flight was Updated Successfully");
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

        //This fills the Flight comboBox with the information for each flight from the database by displaying FLightID, Departure and Arriving Airport and the Date
        public void fillFlights()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT Flight.flightID, Flight.date, Route.depAirport, Route.arrAirport FROM Flight INNER JOIN Route ON Flight.routeID = Route.routeID;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String date = reader["date"].ToString();
                        String[] dateUpdate = date.Split(' ');
                        date = dateUpdate[0];
                        comboBoxFlights.Items.Add(reader["flightID"] + "-" + reader["depAirport"] + "-" + reader["arrAirport"] + "-" + date);
                    }
                    reader.Close();
                }
                con.Close();
            }
        }

        //This fills the routes that are avlailable with the ID, Departure Airport and Arrival Airport
        public void fillRoutes()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT routeID, depAirport, arrAirport FROM Route";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxRoutes.Items.Add(reader["routeID"] + "-" + reader["depAirport"] + "-" + reader["arrAirport"]);
                    }
                    reader.Close();
                }
                con.Close();
            }
            fillAircraft();
        }

        //This fills the Aircraft ComboBox with the information in the database
        public void fillAircraft()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT aircraftID, type FROM Aircraft";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxAircraft.Items.Add(reader["aircraftID"] + "-" + reader["type"]);
                    }
                    reader.Close();
                }
                con.Close();
            }
        }

    }
}
