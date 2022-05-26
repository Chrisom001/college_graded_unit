using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo.CustServ
{
    public partial class CreateCustomer : Form
    {
        private String version;
        private String dbConnection;
        public CreateCustomer()
        {
            InitializeComponent();
            startup();
        }
        //This returns the user to the Customer Service Menu
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            CustServMenu menu = new CustServMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }

        private void startup()
        {
            ImportantCode test = new ImportantCode();
            version = test.versionNumber();
            labelVersion.Text = version;
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            dbConnection = test.dbConnection();
        }
        //This takes the values entered by the user and passes it to the Empty Check function
        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {

            emptyCheck(textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress1.Text, textBoxAddress2.Text, textBoxTown.Text, textBoxPostCode.Text, textBoxTelephone.Text, textBoxEmail.Text);
        }

        //This checks all the details provided by the user and if there isn't something entered into the critical sections it then
        //returns an error to the user. Otherwise it creates the customer
        private void emptyCheck(String firstName, String lastName, String address1, String address2, String town, String postcode, String telephone, String email)
        {
            if (string.IsNullOrEmpty(firstName))
                MessageBox.Show("Please enter the Customers First Name");
            else if (string.IsNullOrEmpty(lastName))
                MessageBox.Show("Please enter the Customers Last Name");
            else if (string.IsNullOrEmpty(address1))
                MessageBox.Show("Please enter the Customers 1st Line of Address");
            else if (string.IsNullOrEmpty(town))
                MessageBox.Show("Please enter the Customers Town");
            else if (string.IsNullOrEmpty(postcode))
                MessageBox.Show("Please enter the Postcode");
            else if (string.IsNullOrEmpty(telephone))
                MessageBox.Show("Please enter a contact number");
            else
                CreateCust(firstName, lastName, address1, address2, town, postcode, telephone, email);

        }

        //This inserts the details given by the user into a new record in the database
        private void CreateCust(String firstName, String lastName, String address1, String address2, String town, String postcode, String telephone, String email)
        {
            String sql = "INSERT INTO Customer(firstName, lastName, address1, address2, town, postcode, contactNumber, contactEmail, lastBooked) VALUES(@fName, @lName, @address1, @address2, @town, @postcode, @contactNumber, @contactEmail, @lastBooked)";
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

                cmd.Parameters.AddWithValue("@fName", firstName);
                cmd.Parameters.AddWithValue("@lName", lastName);
                cmd.Parameters.AddWithValue("@address1", address1);
                cmd.Parameters.AddWithValue("@address2", address2);
                cmd.Parameters.AddWithValue("@town", town);
                cmd.Parameters.AddWithValue("@postcode", postcode);
                cmd.Parameters.AddWithValue("@contactNumber", telephone);
                cmd.Parameters.AddWithValue("@contactEmail", email);
                cmd.Parameters.AddWithValue("@lastBooked", "01/01/1970");
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The user was Added Successfully");
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
    }
}
