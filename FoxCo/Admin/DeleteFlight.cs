using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo.Admin
{
    public partial class DeleteFlight : Form
    {
        private String dbConnection;
        private String version;

        public DeleteFlight()
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
            fillFlights();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            AdminMenu admin = new AdminMenu();
            this.Close();
            this.Dispose();
            admin.ShowDialog();
        }

        //This fills the flights comboxBox from the information in the database
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

        //This picks the flightID from the comboxBoxes selected item and sends it to the delete flight function
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxFlights.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flight from the dropdown list");
            } else
            {
                String delete = comboBoxFlights.SelectedItem.ToString();
                String[] flightID = delete.Split('-');
                DelFlight(flightID[0]);
            }
            
        }

        //This asks the user to confirm that they want the flight to be deleted. If they do it then moves onto the final delete function
        private void DelFlight(String flightID)
        {
            string message = "Are you sure you wish to delete this flight?";
            string messageBoxName = "Delete Flight";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, messageBoxName, buttons);

            if (result == DialogResult.Yes)
            {
                bookingCheck(flightID);
            }
        }

        //this checks to see if there are any bookings for the flight
        private void bookingCheck(string flightIDs)
        {
            int count = 0;
            int flightID = Int32.Parse(flightIDs);

            String sql = "SELECT Count(passengerID) FROM Passenger WHERE flightID = @flightID";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@flightID", flightID);
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

            if (count >= 1)
                passengerDelete(flightID);
            else
                finalDelete(flightID);
        }

        //This deletes the passengers
        private void passengerDelete(int flightID)
        {
            String sql = "DELETE FROM Passenger WHERE flightID = @flightID";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            using (SqlCommand delCommand = new SqlCommand(sql, con))
            {
                delCommand.Parameters.AddWithValue("@flightID", flightID);
                con.Open();
                delCommand.ExecuteNonQuery();
                con.Close();
            }
            bookingDelete(flightID);
        }

        //This deletes bookings with no Passengers
        private void bookingDelete(int flightID)
        {
            String sql = "DELETE FROM Booking WHERE bookingRef NOT IN (SELECT bookingRef FROM Passenger)";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            using (SqlCommand delCommand = new SqlCommand(sql, con))
            {
                con.Open();
                delCommand.ExecuteNonQuery();
                con.Close();
            }
            finalDelete(flightID);
        }

        //This deletes the flight with the specified ID from the database and then sends the user back to the Admin Menu
        private void finalDelete(int flightID)
        {
            String deleteQuery = "DELETE FROM Flight WHERE flightID = @flightID";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            using (SqlCommand delCommand = new SqlCommand(deleteQuery, con))
            {
                delCommand.Parameters.AddWithValue("@flightID", flightID);
                con.Open();
                delCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Flight has been deleted");
                AdminMenu create = new AdminMenu();
                this.Close();
                this.Dispose();
                create.ShowDialog();
            }
        }
    }
}
