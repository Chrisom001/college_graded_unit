using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo.CustServ
{
    public partial class ModifyBooking : Form
    {

        private String dbConnection;

        public ModifyBooking()
        {
            InitializeComponent();
            startup();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int bookingNumber;

            bool parse = Int32.TryParse(textBoxBookingNumber.Text, out bookingNumber);

            if (!parse)
                MessageBox.Show("Please enter the Booking Number as a number");
            else
                bookingSearch(bookingNumber);
        }

        //After the intial check, it then looks for the booking reference in the database
        private void bookingSearch(int BookingNumber)
        {
            int count = 0;
            
            String query = "SELECT COUNT(bookingRef) from Booking where bookingRef = @bookingRef;";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@bookingRef", BookingNumber);
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

            //If the booking reference exists, it then displays the details for this booking
            //Otherwise it informs the user that the booking reference doesn't exist
            if (count > 0)
            {
                displayDetails();
            }
                
            else
                MessageBox.Show("There was no booking found for " + BookingNumber + " please try again");
        }

        //This takes the booking refernece supplied by the user and uses it to fill the text boxes and labels with the passengersd
        //information as well as starting the elements display
        private void displayDetails()
        {
            textBoxBookingNumber.Enabled = false;
            buttonSearch.Enabled = false;
            labelInfo.Visible = true;
            comboBoxRoute.Visible = true;
            labelRoute.Visible = true;
        }

        private void fillRoutes()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT routeID, depAirport, arrAirport FROM Route;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxRoute.Items.Add(reader["routeID"] + "-" + reader["depAirport"] + " to " + reader["arrAirport"]);
                    }
                    reader.Close();
                }
                con.Close();
            }
        }

        private void flightFill(int routeID)
        {
            DateTime date = DateTime.Now;
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT flightID, date FROM Flight WHERE routeID = @routeID AND date >= @date;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@routeID", routeID);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String[] value = reader["date"].ToString().Split(' ');
                        String dateValue = value[0];
                        comboBoxFlights.Items.Add(reader["flightID"] + "-" + dateValue);
                    }
                    reader.Close();
                }
                con.Close();
            }
        }

        private void startup()
        {
            ImportantCode test = new ImportantCode();
            labelVersion.Text = test.versionNumber();
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            dbConnection = test.dbConnection();
            fillRoutes();
        }

        private void comboBoxRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            int routeID;
            string selected = comboBoxRoute.SelectedItem.ToString();
            string[] value = selected.Split('-');
            routeID = Int32.Parse(value[0]);
            if (flightCheck(routeID))
            {
                seatCost(routeID);
                flightFill(routeID);

                comboBoxRoute.Enabled = false;
                labelFlights.Visible = true;
                comboBoxFlights.Visible = true;
                labelPrice.Visible = true;
                labelCost.Visible = true;
            }
            else
                MessageBox.Show("There are no Flights scheduled for this Route");
        }

        private void seatCost(int routeID)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT seatCost FROM Route WHERE routeID = @routeID;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@routeID", routeID);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        labelPrice.Text = "£ " + reader["seatCost"].ToString();
                    }
                    reader.Close();
                }
                con.Close();
            }
        }

        private Boolean flightCheck(int routeID)
        {
            int count = 0;
            DateTime date = DateTime.Now;
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "select count(flightID) FROM Flight where date >= @date AND routeID = @routeID;";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@routeID", routeID);
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

        private void comboBoxFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] value = comboBoxFlights.SelectedItem.ToString().Split('-');

            int flightID = Int32.Parse(value[0].ToString());

            fillSeats(flightID);
            comboBoxFlights.Enabled = false;
            labelInfo2.Visible = true;
            labelinfo3.Visible = true;
            labelpassengerName.Visible = true;
            labelPassenger.Visible = true;
            labelseat.Visible = true;
            comboBoxSeatList.Visible = true;
            labelpassengerName.Text = customerName();
        }

        private void fillSeats(int flightID)
        {
            int NumberOfSeats = seatNumber(flightID);

            for (int i = 0; i <= NumberOfSeats; i++)
            {
                comboBoxSeatList.Items.Add(seatBooked(i, flightID));
            }
        }

        private String seatBooked(int SeatNumber, int flightID)
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
                return "Seat " + "-" + " " + SeatNumber + " " + "-" + " is booked";
            else
                return "Seat " + "-" + " " + SeatNumber + " " + "-" + " is not booked";
        }

        private int seatNumber(int flightID)
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

        private String customerName()
        {
            String customerName = "";
            int bookingRef = Int32.Parse(textBoxBookingNumber.Text);
            String query = "SELECT firstName, lastName FROM Passenger WHERE bookingRef = @bookingRef;";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@bookingRef", bookingRef);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customerName = reader[0] + " " + reader[1];
                    }
                    reader.Close();
                }
                con.Close();
            }

            return customerName;
        }

        private void comboBoxSeatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSubmit.Visible = true;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            CustServMenu menu = new CustServMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String[] seat = comboBoxSeatList.SelectedItem.ToString().Split('-');
            String bookedValue = seat[2].ToString();
            String finalSeat = seat[1].ToString();

            if (comboBoxSeatList.SelectedIndex == -1)
                MessageBox.Show("Please select a Seat");
            else if (seatAlreadyBooked(bookedValue))
            {
                MessageBox.Show("Seat is already booked, please try another");
            }
            else
                updateBooking(finalSeat);
        }

        private void updateBooking(String seat)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            int bookingRef = Int32.Parse(textBoxBookingNumber.Text);
            String[] flight = comboBoxFlights.SelectedItem.ToString().Split('-');
            int flightID = Int32.Parse(flight[0]);
            String[] value1 = labelPrice.Text.ToString().Split(' ');
            double price = double.Parse(value1[1]);
            string bookingSql = "UPDATE Booking SET cost = @cost where bookingRef = @bookingRef;";
            string passengerSql = "UPDATE Passenger SET passengerSeat = @passengerSeat, flightID = @flightID WHERE bookingRef = @bookingRef";

            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            using (var cmd = new SqlCommand(bookingSql, con))
            {
                cmd.Parameters.AddWithValue("@bookingRef", bookingRef);
                cmd.Parameters.AddWithValue("@cost", price);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

            using (var cmd = new SqlCommand(passengerSql, con))
            {
                cmd.Parameters.AddWithValue("@bookingRef", bookingRef);
                cmd.Parameters.AddWithValue("@passengerSeat", seat);
                cmd.Parameters.AddWithValue("@flightID", flightID);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The booking was updated Successfully");
                    CustServMenu menu = new CustServMenu();
                    this.Close();
                    this.Dispose();
                    menu.ShowDialog();
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

        private Boolean seatAlreadyBooked(String selectedSeat)
        {
            
            if (selectedSeat.Equals(" is booked", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
