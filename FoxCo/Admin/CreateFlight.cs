using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace FoxCo.Admin
{
    public partial class CreateFlight : Form
    {
        private String dbConnection;
        private String version;
        private int distance;
        private int range;

        public CreateFlight()
        {
            InitializeComponent();
            startup();
        }

        public void startup()
        {
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            ImportantCode test = new ImportantCode();
            version = test.versionNumber();
            labelVersion.Text = version;
            dbConnection = test.dbConnection();
            fillRoutes();
        }

        //This looks in the database for the routes which are available and fills the comboBox with the
        //information immediately so the user can choose.
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
                        comboBoxRoutes.Items.Add(reader["routeID"] + "-" +reader["depAirport"] + "-" + reader["arrAirport"]);
                    }
                    reader.Close();
                }
                con.Close();
            }
            fillAircraft();
        }

        //This fills the Aircraft comboBox with the information held in the Aircraft table of the Database
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


        private void buttonCreateFlight_Click(object sender, EventArgs e)
        {
            int routeID = 0;
            String aircraftID = "";
            //This checks if the user hasn't selected a route, if not it urges them to do so
            if (comboBoxRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a route");
            }
            else
            {
                String[] routes = comboBoxRoutes.Items[comboBoxRoutes.SelectedIndex].ToString().Split('-');
                routeID = Int32.Parse(routes[0]);
                //This checks if the user has selected an Aircraft, if not, it urges them to do so
                if (comboBoxAircraft.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an Aircraft");
                }
                else
                {
                    String[] aircraft = comboBoxAircraft.Items[comboBoxAircraft.SelectedIndex].ToString().Split('-');
                    aircraftID = aircraft[0];
                    //This checks if the range on the plane is sufficient for the journey, if not it urges the user to select another
                    if (!rangeCheck(routeID, aircraftID))
                    {
                        MessageBox.Show("This plane cannot make the journey, Please try selecting another");
                    } else
                    {
                        //If the user selected a date that's in the past, the program highlights this to the user
                        if(monthCalendar1.SelectionRange.Start < monthCalendar1.TodayDate)
                        {
                            MessageBox.Show("Please select a date that is in the future");
                        }
                        else
                        {
                            String date = monthCalendar1.SelectionRange.Start.ToShortDateString();
                            String[] dateUpdate = date.Split('/');
                            date = dateUpdate[1] + "/" + dateUpdate[0] + "/" + dateUpdate[2];

                            //This checks if an aircraft is already scheduled to be on a flight that day, if it is, it 
                            //tells the user that they should choose another plane, if not it moves to insert the flight
                            if (!checkAlreadyOnFlight(aircraftID, date))
                                insertFlight(routeID, aircraftID, date);
                            else
                                MessageBox.Show("This plane is already scheduled for a flight on this date, please choose another plane");
                        }
                            
                    }
                }
            }
        }

        //This inserts the flight into the database so it can be used in future
        private void insertFlight(int routeID, String aircraftID, String date)
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

            string sql = "INSERT INTO Flight (aircraftID, routeID, date) VALUES (@aircraftID, @routeID, @date)";
            using (var cmd = new SqlCommand(sql, con))
            {

                cmd.Parameters.AddWithValue("@aircraftID", aircraftID);
                cmd.Parameters.AddWithValue("@routeID", routeID);
                cmd.Parameters.AddWithValue("@date", date);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Flight was added Successfully");
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

        //This checks if a plane is already on a flight, if it is, it returns true and if not, it returns false
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
        private bool rangeCheck(int route, String aircraft)
        {
            range = 0;
            distance = 0;
            routeDistance(route);
            planeRange(aircraft);

            if(range > (distance + 200))
            {
                return true;
            } else
            {
                return false;
            }           
        }

        //This gets the distance for a route based on the routeID passed through
        private void routeDistance(int route)
        {
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
        }

        //This gets the range of the plane based on the aircraftID provided
        private void planeRange(String aircraft)
        {
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
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            AdminMenu admin = new AdminMenu();
            this.Close();
            this.Dispose();
            admin.ShowDialog();
        }
    }
}
