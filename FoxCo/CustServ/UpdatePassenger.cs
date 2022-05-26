using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo.CustServ
{
    public partial class UpdatePassenger : Form
    {
        private String dbConnection;

        public UpdatePassenger()
        {
            InitializeComponent();
            startup();
        }

        //This takes the entered booking number and checks to ensure it is a number
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
                displayDetails(BookingNumber);
            else
                MessageBox.Show("There was no booking found for " + BookingNumber + " please try again");
        }

        
        //This takes the booking refernece supplied by the user and uses it to fill the text boxes and labels with the passengersd
        //information as well as starting the elements display
        private void displayDetails(int BookingNumber)
        {
            elementDisplay();

            String query = "select Booking.bookingRef, Passenger.firstName, Passenger.lastName, Passenger.passengerSeat, Passenger.flightID FROM Booking INNER JOIN Passenger ON Booking.bookingRef = Passenger.bookingRef WHERE Booking.bookingRef = @bookingRef;";
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
                        labelFirstNamePrev.Text = reader[1].ToString();
                        labelLastNamePrev.Text = reader[2].ToString();
                        labelSeatPrev.Text = reader[3].ToString();

                        textBoxFirstName.Text = reader[1].ToString();
                        textBoxLastName.Text = reader[2].ToString();

                        fillSeats(reader[4].ToString());
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
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            CustServMenu menu = new CustServMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }

        //This takes the flightID recieved during the search for the Passengers Information and determines how many seats a plane has
        //And also then fills the combobox with the relevant seats
        private void fillSeats(String flightIDs)
        {
            int flightID = Int32.Parse(flightIDs);
            int NumberOfSeats = seatNumber(flightID);

            for (int i = 0; i <= NumberOfSeats; i++)
            {
                comboBoxSeat.Items.Add(seatBooked(i, flightID));
            }
        }

        //This looks at the seats which are booked on each flight and returns the value as well as telling the user whether it's booked
        //or not booked .
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

        // This looks at the number of seats on the flight based on the number of seats avaliable on the plane assigned.
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

        //This shows and hides the relevant elements when the search box is hit and a result is found.
        private void elementDisplay()
        {
            labelInfo.Visible = true;
            labelFirstName.Visible = true;
            labelFirstNamePrev.Visible = true;
            labelLastName.Visible = true;
            labelLastNamePrev.Visible = true;
            labelSeat.Visible = true;
            labelSeatPrev.Visible = true;
            labelNew.Visible = true;
            labelPrevious.Visible = true;
            buttonSubmit.Visible = true;
            textBoxFirstName.Visible = true;
            textBoxLastName.Visible = true;
            comboBoxSeat.Visible = true;

            labelSearch.Visible = false;
            textBoxBookingNumber.Visible = false;
            buttonSearch.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            entryCheck(textBoxFirstName.Text, textBoxLastName.Text, comboBoxSeat.SelectedIndex.ToString());
            
        }

        //This checks to make sure that there is a value entered for the passengers first and last name and has a seat number which isn't booked.
        private void entryCheck(String firstName, String lastName, String Seat)
        {
            int SeatIndex = Int32.Parse(Seat);

            if (string.IsNullOrWhiteSpace(firstName))
                MessageBox.Show("Please enter the Customers First Name");
            else if (string.IsNullOrWhiteSpace(lastName))
                MessageBox.Show("Please enter the customers Last Name");
            else if (SeatIndex == -1)
                MessageBox.Show("Please select a seat for the Customer");
            else if (seatAlreadyBooked())
                MessageBox.Show("Please select a seat which isn't booked");
            else
                userConfirm();
        }

        //This asks the user to confirm whether they want to update the passenger, if they do it starts the update
        //If not, it does nothing
        private void userConfirm()
        {
            string message = "Are you sure that you would like to update this passenger?";
            string caption = "Update Passenger";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                updatePassenger();
            }
        }

        //This updates the passenger with the information in the text boxes
        private void updatePassenger()
        {
            String finalSeat;
            String[] value = comboBoxSeat.SelectedItem.ToString().Split('-');
            finalSeat = value[1];
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");

            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            string sql = "UPDATE Passenger set firstName = @fName, lastName = @lName, passengerSeat = @passengerSeat WHERE bookingRef = @bookingRef";
            using (var cmd = new SqlCommand(sql, con))
            {

                cmd.Parameters.AddWithValue("@fName", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@lName", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@passengerSeat", finalSeat);
                cmd.Parameters.AddWithValue("@bookingRef", textBoxBookingNumber.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Passenger was updated successfully");
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

        // This checks to ensure that the seat isn't already booked on the flight.
        private Boolean seatAlreadyBooked()
        {
            String[] seat = comboBoxSeat.SelectedItem.ToString().Split('-');
            String value = seat[2].ToString();
            if (value.Equals(" is booked", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBoxBookingNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
