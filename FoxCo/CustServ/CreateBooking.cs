using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo.CustServ
{
    public partial class CreateBooking : Form
    {
        private String dbConnection;
         
        public CreateBooking()
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
            fillCustomer();
            fillRoutes();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            CustServMenu menu = new CustServMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }

        //This takes the customer information from the database and displays it within a comboBox with their ID, First and Last Names.
        private void fillCustomer()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT custID, firstName, lastName FROM Customer;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxCustomer.Items.Add(reader["custID"] + "-" + reader["firstName"] + " " + reader["lastName"]);
                    }
                    reader.Close();
                }
                con.Close();
            }
        }

        //This takes all the routes in the database and displays them within a ComboBox
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

        //When the Route comboBox is changed, it sends the routeID to the FlightCheck and if there isn't a flight it returns an error
        //otherwise it then sends teh routeID to the SeatCost and FlightFill functions and triggers the displayItems function.
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
                displayItems();
            }
            else
                MessageBox.Show("There are no Flights scheduled for this Route");
            
        }

        //This checks for the cost of a seat on a flight from the Route table based on the routeID sent to it.
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

        //This takes the routeID that has been given and looks at dates from today onwards, and fills a comboBox with all flights that are avaliable
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

        //This checks if there are any flights either today or in the future based on the routeID supplied to it. If there are any it returns true
        //otherwise it returns false.
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

        //This disables the Route Combobox once the user has selected a route that has active flights and makes the labels for Price and FLight visible
        // as well as the flights ComboBox
        private void displayItems()
        {
            labelCost.Visible = true;
            labelPrice.Visible = true;
            labelFlights.Visible = true;
            comboBoxFlights.Visible = true;
            comboBoxRoute.Enabled = false;
        }

        //
        private void buttonEntDetails_Click(object sender, EventArgs e)
        {
            //This creates a random Booking Refernece for the booking
            Random rnd = new Random();
            int bookingRef = rnd.Next(999999);

            int custID;
            double price;
            int flightID;
            //This takes the input from the Customer Selected and splits it in order to get the Customers ID number
            String custInput = comboBoxCustomer.SelectedItem.ToString();
            String[] value = custInput.Split('-');
            custID = Int32.Parse(value[0]);

            //This takes the price in the Label and takes away the Pound symbol to give the double value only
            String priceInput = labelPrice.Text.ToString();
            value = priceInput.Split(' ');
            price = double.Parse(value[1]);

            //This takes the flight information selecte din the ComboBox and splits it to get the flight ID only
            String flightIDInput = comboBoxFlights.SelectedItem.ToString();
            value = flightIDInput.Split('-');
            flightID = Int32.Parse(value[0]);

            //This checks to ensure that the booking Reference doesn't already exist. if it does it alerts the user and creates a new reference number
            while (bookingRefCheck(bookingRef))
            {
                MessageBox.Show("Duplicate");
                bookingRef = rnd.Next(999999);
            }

            insertBooking(bookingRef, custID, price, flightID);
        }

        //This inserts the created booking into the database and tells the user it was successful
        private void insertBooking(int bookingRef, int custID, double price,int flightID)
        {
            String sql = "SET IDENTITY_INSERT Booking ON; INSERT INTO Booking(bookingRef, custID, bookingDate, cost, staffID) VALUES(@bookingRef, @custID, @bookingDate, @cost, @staffID); SET IDENTITY_INSERT Booking Off;";
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

                cmd.Parameters.AddWithValue("@bookingRef", bookingRef);
                cmd.Parameters.AddWithValue("@custID", custID);
                cmd.Parameters.AddWithValue("@bookingDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@cost", price);
                cmd.Parameters.AddWithValue("@staffID", userDetails.userID);
                try
                {
                    cmd.ExecuteNonQuery();
                    
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
            updateLastBooked(custID, bookingRef, flightID);

        }
        //This updates the customers table to show the last booked date as the current date
        private void updateLastBooked(int custID, int bookingRef, int flightID)
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

            String lastBookedsql = "UPDATE Customer SET lastBooked = @bookingDate where custID = @custID";
            using (var cmd = new SqlCommand(lastBookedsql, con))
            {

                cmd.Parameters.AddWithValue("@bookingDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@custID", custID);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Booking was added Successfully");
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

            CreatePassenger newPas = new CreatePassenger(bookingRef, flightID);
            this.Close();
            this.Dispose();
            newPas.ShowDialog();
        }

        //This checks the database to see if the randomly generated booking reference has already been used. If it has been, it returns true, if not it returns false
        private Boolean bookingRefCheck(int bookingRef)
        {
            int count = 0;
            DateTime date = DateTime.Now;
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "select count(bookingRef) FROM Booking where bookingRef = @bookingRef;";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@bookingRef", bookingRef);
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
        //When the user selects a flight, it makes the enter button visisble
        private void comboBoxFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEntDetails.Visible = true;
        }

        //When the user selecteds a customer, it disables the customers comboBox and makes the Route one visible
        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCustomer.Enabled = false;
            labelRoute.Visible = true;
            comboBoxRoute.Visible = true;
        }
    }
}
