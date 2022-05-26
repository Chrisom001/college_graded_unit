using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo.Admin
{
    public partial class AdminMenu : Form
    {
        private String dbConnection = "";
        
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            startup();
        }

        public void startup()
        {
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            ImportantCode test = new ImportantCode();
            String version = test.versionNumber();
            labelVersion.Text = version;
            dbConnection = test.dbConnection();
        }

        //This takes the user to the Update Staff section
        private void buttonUpdStaff_Click(object sender, EventArgs e)
        {
            ModifyStaff create = new ModifyStaff();
            this.Close();
            this.Dispose();
            create.ShowDialog();
        }

        //This takes the user to the Create Staff section
        private void buttonCreStaff_Click(object sender, EventArgs e)
        {
            CreateStaff create = new CreateStaff();
            this.Close();
            this.Dispose();
            create.ShowDialog();
        }

        //This takes the customer to the Delete Staff section
        private void buttonDelStaff_Click(object sender, EventArgs e)
        {
            DeleteStaff delete = new DeleteStaff();
            this.Close();
            this.Dispose();
            delete.ShowDialog();
        }

        //This takes the user to the Create Flight section
        private void buttonCreFlight_Click(object sender, EventArgs e)
        {
            CreateFlight create = new CreateFlight();
            this.Close();
            this.Dispose();
            create.ShowDialog();
        }

        //This takes the user to the update Flight section
        private void buttonUpdFlight_Click(object sender, EventArgs e)
        {
            UpdateFlight update = new UpdateFlight();
            this.Close();
            this.Dispose();
            update.ShowDialog();
        }

        //This takes the user to the Delete Flight section
        private void buttonDelFlight_Click(object sender, EventArgs e)
        {
            DeleteFlight delete = new DeleteFlight();
            this.Close();
            this.Dispose();
            delete.ShowDialog();
        }

        //This takes the user back to the Main Menu
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }

        //This asks the user to confirm they wish to delete customer accounts older than 12 months. If they say yes, it then moves to the next section
        private void buttonDelCustomer_Click(object sender, EventArgs e)
        {
            string message = "Are you sure that you would like to delete all customers without a booking in the last 12 months?";
            string caption = "Delete Customers";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                getCustomerCount();
            }
        }

        //This counts the number of user accounts that require deletion and passes this onto the next section of the deletion
        private void getCustomerCount()
        {
            DateTime lastYear = DateTime.Today.AddYears(-1);
            int count = 0;

            String sql = "SELECT Count(custID) FROM Customer WHERE lastBooked <= @lastYear";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@lastYear", lastYear);
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

            getCustomerID(count, lastYear);
        }

        //This takes the number of users requiring deletion and gets their customer ID. It then passes this to the booking
        //query to find any bookings that need deletion
        private void getCustomerID(int count, DateTime lastYear)
        {
            if (count == 0)
                MessageBox.Show("There are no customer accounts that require deletion");
            else
            {
                String sql = "SELECT custID FROM Customer WHERE lastBooked <= @lastYear";
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@lastYear", lastYear);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for(int i = 0; i <= count; i++)
                            {
                                countBookingReference(Int32.Parse(reader[0].ToString()), lastYear);
                            }
                        }
                        reader.Close();
                    }
                    con.Close();
                }
            }
        }


        //This counts the number of bookings that require deletion based on the customer ID passed through by the previous function and then
        //passes this count to the next section
        private void countBookingReference(int custID, DateTime lastYear)
        {
            int count = 0;

            String sql = "SELECT Count(bookingRef) FROM Booking WHERE custID = @custID";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@custID", custID);
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

            getBookingReference(custID, count, lastYear);
        }

        //This takes the count and then finds the booking references that need to be deleted, and then passes it to the 
        //Passenger deletion and Booking deletion functions before finally moving to the Customer Deletion
        private void getBookingReference(int custID, int count, DateTime lastYear)
        {
            if (count >= 1)
            {
                String sql = "SELECT bookingRef FROM Booking WHERE custID = @custID";
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@custID", custID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i <= count; i++)
                            {
                                deletePassengers(Int32.Parse(reader[0].ToString()));
                                deleteBookings(Int32.Parse(reader[0].ToString()));
                            }
                        }
                        reader.Close();
                    }
                    con.Close();

                    deleteCustomer(custID, lastYear);
                }
            } else
            {
                MessageBox.Show("There are no bookings that require deletion, only the customer will be deleted");
                deleteCustomer(custID, lastYear);
            }
        }

        //This deletes all passengers with the Booking reference that is passed through
        private void deletePassengers(int bookingRef)
        {
            String sql = "DELETE FROM Passenger WHERE bookingRef = @bookingRef";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            using (SqlCommand delCommand = new SqlCommand(sql, con))
            {
                delCommand.Parameters.AddWithValue("@bookingRef", bookingRef);
                con.Open();
                delCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        //This deletes all bookings with the booking referneces passed through
        private void deleteBookings(int bookingRef)
        {
            String sql = "DELETE FROM Booking WHERE bookingRef = @bookingRef";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            using (SqlCommand delCommand = new SqlCommand(sql, con))
            {
                delCommand.Parameters.AddWithValue("@bookingRef", bookingRef);
                con.Open();
                delCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        //This deletes all customers with the Customer ID that is passed through
        private void deleteCustomer(int custID, DateTime lastYear)
        {
            String sql = "DELETE FROM Customer WHERE lastBooked <= @lastYear";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            using (SqlCommand delCommand = new SqlCommand(sql, con))
            {
                delCommand.Parameters.AddWithValue("@lastYear", lastYear);
                con.Open();
                delCommand.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
