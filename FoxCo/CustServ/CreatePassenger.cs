using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo.CustServ
{
    public partial class CreatePassenger : Form
    {
        private String dbConnection;
        private int bookingRef;
        private int flightID;
        public CreatePassenger(int bookingRefs, int flightIDs)
        {
            bookingRef = bookingRefs;
            flightID = flightIDs;

            InitializeComponent();
            startup();
        }

        private void startup()
        {
            ImportantCode test = new ImportantCode();
            labelVersion.Text = test.versionNumber();
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            dbConnection = test.dbConnection();
            labelBookingRefs.Text = bookingRef.ToString();
            fillSeats();
        }
        
        //This gets the number of seats on the plane from the Seat Number function
        // and it then takes this and iterates through to fill the comboBox by using the 
        //seatBooked function
        private void fillSeats()
        {
            int NumberOfSeats = seatNumber();

            for (int i = 0; i <= NumberOfSeats; i++)
            {
                comboBoxSeatList.Items.Add(seatBooked(i));
            }         
        }
        //This checks the seat number that is passed through to it
        //it then uses the flightID and seat Number to find out if
        // a particular seat on a place is booked. If it is it returns a 
        //String to say this otherwise it returns another string to say it
        //isn't booked.
        private String seatBooked(int SeatNumber)
        {
            int result = 0;
            String query = "SELECT COUNT(passengerSeat) from Passenger where flightID = @flightID AND passengerSeat = @seatNumber;";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@flightID", flightID);
                cmd.Parameters.AddWithValue("@seatNumber", SeatNumber);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = Int32.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                con.Close();
            }

            if (result > 0)
                return "Seat " + "-" + " " + SeatNumber + " " +"-" +" is booked";
            else
                return "Seat " + "-" + " " + SeatNumber + " " + "-" + " is not booked";
        }
        //This takes the flight ID and finds out which plane is assigned to the flight. Before using this as part of a Join
        //in order to find out how many seats are on the plane.
        private int seatNumber()
        {
            int quantity = 0;
            String query = "SELECT Aircraft.seats FROM Aircraft INNER JOIN Flight ON Flight.aircraftID = Aircraft.aircraftID WHERE Flight.flightID = @flightID;";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@flightID", flightID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        quantity = Int32.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                con.Close();
            }
            return quantity;
        }

        //This checks the details given to ensure that there is a value entered for the first and last name and that a seat has been selected
        //It also checks to ensure that the seat isn't already booked and if it is it informs the user of this.
        //If all the checks are passed, it moves to inser the passenger
        private void buttonEnterPassenger_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
                MessageBox.Show("Please enter the Passengers First Name");
            else if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
                MessageBox.Show("Please enter the Passengers Last Name");
            else if (comboBoxSeatList.SelectedIndex == -1)
                MessageBox.Show("Please select a Seat");
            else if (seatAlreadyBooked(comboBoxSeatList.SelectedItem.ToString()))
                 MessageBox.Show("Seat is already booked, please try another");
            else
                insertPassenger(textBoxFirstName.Text, textBoxLastName.Text, comboBoxSeatList.SelectedItem.ToString());

        }

        //This takes the string in the comboBoxes selected item and splits it up and looks for the string
        //"Is Booked" and if it finds this, it returns true otherwise it returns false
        private Boolean seatAlreadyBooked(String selectedSeat)
        {
            String[] seat = selectedSeat.Split('-');
            String value = seat[2].ToString();
            if (value.Equals(" is booked", StringComparison.InvariantCultureIgnoreCase)){
                return true;
            } else
            {
                return false;
            }
        }

        //This takes the values given and inserts the information into the database for the passenger
        private void insertPassenger(String fName, String lName, String seat)
        {
            //This creates a random passenger number and checks to ensure that it isn't duplicated.
            Random rnd = new Random();
            int passengerID = rnd.Next(9999);
            while (passengerIDCheck(passengerID))
            {
                MessageBox.Show("Duplicate");
                passengerID = rnd.Next(9999);
            }

            String finalSeat;
            String[] value = seat.Split('-');
            finalSeat = value[1];
            String sql = "INSERT INTO Passenger(passengerID, firstName, lastName, passengerSeat, bookingRef, flightID) VALUES(@passengerID, @fName, @lname, @passengerSeat ,@bookingRef , @flightID);";
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
                cmd.Parameters.AddWithValue("@passengerID", passengerID);
                cmd.Parameters.AddWithValue("@fName", fName);
                cmd.Parameters.AddWithValue("@lName", lName);
                cmd.Parameters.AddWithValue("@passengerSeat", finalSeat);
                cmd.Parameters.AddWithValue("@bookingRef", bookingRef);
                cmd.Parameters.AddWithValue("@flightID", flightID);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Passenger was Added Successfully");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                try
                {
                    con.Close();
                    CustServMenu menu = new CustServMenu();
                    this.Close();
                    this.Dispose();
                    menu.ShowDialog();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

            
        }

        //This checks the randomly generated passenger ID against hte ones in the database. If it exists it returns true, otherwise it returns false.
        private Boolean passengerIDCheck(int passengerRef)
        {
            int count = 0;
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "select count(passengerID) FROM Passenger where passengerID = @passengerID;";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@passengerID", passengerRef);
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
    }
}
