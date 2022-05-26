using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FoxCo.CustServ
{
    public partial class DeleteBooking : Form
    {
        private String dbConnection;

        public DeleteBooking()
        {
            InitializeComponent();
            startup();
        }

        private void startup()
        {
            ImportantCode test = new ImportantCode();
            labelVersion.Text = test.versionNumber();
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            dbConnection = test.dbConnection();
        }
        //This takes the booking number supplied by the user and if it isn't a number it returns an error to the user
        //If it is a number, it then passes it to the search function
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int bookingNumber;

            bool parse = Int32.TryParse(textBoxBookingNumber.Text, out bookingNumber);

            if (!parse)
                MessageBox.Show("Please enter the Booking Number as a number");
            else
                bookingSearch(bookingNumber);
        }

        //This checks the database to see if the booking reference exists. If it does it moves to the display details function otherwise it tells the user
        //that there was no booking with the number given

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

            if (count > 0)
                displayDetails(BookingNumber);
            else
                MessageBox.Show("There was no booking found for " + BookingNumber + " please try again");
        }

        //This hides the search button, text box when they search for a valid bokoing reference that does exist
        private void elementDisplay()
        {
            labelBookingNumber.Visible = true;
            labelBookNumInfo.Visible = true;
            labelCustName.Visible = true;
            labelCustNameInfo.Visible = true;
            labelPassNameInfo.Visible = true;
            labelPassName.Visible = true;
            labelSeat.Visible = true;
            labelSeatNumInfo.Visible = true;
            labelInfo1.Visible = true;
            labelInfo2.Visible = true;
            buttonSubmit.Visible = true;

            labelSearch.Visible = false;
            textBoxBookingNumber.Visible = false;
            buttonSearch.Visible = false;
        }

        //This takes the information from the database based on the booking number given and displays the Booking Reference, Customers Name, Passengers Name and Seat number
        //in the appropriate labels
        private void displayDetails(int BookingNumber)
        {
            elementDisplay();

            String query = "select Booking.bookingRef, Passenger.firstName, Passenger.lastName, Passenger.passengerSeat ,Customer.firstName, Customer.lastName FROM Booking INNER JOIN Passenger ON Booking.bookingRef = Passenger.bookingRef INNER JOIN Customer ON Booking.custID = Customer.custID WHERE Booking.bookingRef = @bookingRef;";
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
                        labelBookingNumber.Text = reader[0].ToString();
                        labelCustName.Text = reader[4].ToString() + " " + reader[5].ToString();
                        labelPassName.Text = reader[1].ToString() + " " + reader[2].ToString();
                        labelSeat.Text = "Seat " + reader[3].ToString();
                    }
                    reader.Close();
                }
                con.Close();
            }
        }
        //This returns the user to the customer service menu
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            CustServMenu menu = new CustServMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }
        //This asks the user to confirm if they wish to delete the selected booking. If they do it sends the booking refernece to teh delete booking function
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure that you would like to delete this booking?";
            string caption = "Delete Booking";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                deleteBooking(labelBookingNumber.Text);
            }
        }
        //This takes the booking refernece given and deletes the passenger based on the booking reference and then deletes the specified booking
        private void deleteBooking(String bookingNumber)
        {
            int bookingRef = Int32.Parse(bookingNumber);

            String passQuery = "DELETE FROM Passenger where bookingRef = @bookingRef";
            String bookingQuery = "DELETE FROM Booking where bookingRef = @bookingRef";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            using (SqlCommand delCommand = new SqlCommand(passQuery, con))
            {
                delCommand.Parameters.AddWithValue("@bookingRef", bookingRef);
                con.Open();
                delCommand.ExecuteNonQuery();
                con.Close();
            }

            using (SqlCommand delCommand = new SqlCommand(bookingQuery, con))
            {
                delCommand.Parameters.AddWithValue("@bookingRef", bookingRef);
                con.Open();
                delCommand.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Booking has been deleted!");

            CustServMenu menu = new CustServMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }
    }
}
