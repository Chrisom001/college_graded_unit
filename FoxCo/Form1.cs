using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo
{
    public partial class loginScreen : Form
    {
        private String dbConnection;
        private String version;

        public loginScreen()
        {
            InitializeComponent();
            important();
        }

        private void login_Click(object sender, EventArgs e)
        {
            String inputID = staffID.Text;
            String inputPassword = password.Text;
            //This checks if the information entered by the user is Null or Whitespace
            //If it is, it alerts the user to this and lets them try again

            if (string.IsNullOrWhiteSpace(inputID))
            {
                MessageBox.Show("Please enter your StaffID");
            } else if (string.IsNullOrWhiteSpace(inputPassword))
            {
                MessageBox.Show("Please enter your Password!");
            } else
            {
                // This checks if the userID input by the user is a number
                // If it isn't, it shows an error to the user allowing them to fix this
                int id;
                bool parsed = Int32.TryParse(inputID, out id);

                if (!parsed)
                {
                    MessageBox.Show("Please enter your Staff ID as it's Numeric Value");
                }
                else
                {
                    loginCheck(id, inputPassword);
                }
            }
        }

        private void loginCheck(int id, string inputPassword)
        {
            SqlDataReader sdr;
            Boolean result = false;

            //This connects to the database to check if the User ID and Password are correct.
            // If they are, it returns a true result and moves the user to the Main Menu
            // If not, they are shown an error and are told to try to login again

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename ="+dbConnection+"; Integrated Security = True; Connect Timeout = 30");
            con.Open();
            String query = "SELECT * FROM dbo.Staff WHERE staffID = @staffID AND password = @password";
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@staffID", id);
                cmd.Parameters.AddWithValue("@password", inputPassword);
                sdr = cmd.ExecuteReader();
                result = sdr.Read();
            }
            con.Close();

            if (result == true)
            {
                MainMenu menu1 = new MainMenu(id);
                menu1.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please try to login Again");
            }
        }

        private void important()
        {
            ImportantCode test = new ImportantCode();
            version = test.versionNumber();
            dbConnection = test.dbConnection();
            labelVersion.Text = version;
        }

        private void labelCopyright_Click(object sender, EventArgs e)
        {

        }
        // This closes the program when the button is selected.
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
