using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoxCo.Admin
{
    public partial class CreateStaff : Form
    {
        private String version;
        private String dbConnection;

        public CreateStaff()
        {
            InitializeComponent();
            startup();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String fName = textBoxFirstName.Text;
            String lName = textBoxLastName.Text;
            String password = textBoxPassword.Text;
            String insertRole = ((String)comboBoxRole.SelectedItem);
            emptyCheck(fName, lName, password, insertRole);
        }

        private void startup()
        {
            ImportantCode test = new ImportantCode();
            version = test.versionNumber();
            labelVersion.Text = version;
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            dbConnection = test.dbConnection();
        }

        //This checks to make sure that each of the fields has a value and if they don't it tells the user so they can resolve it.
        private void emptyCheck(String fName, String lName, String password, String insertRole)
        {
            String role = "";

            if (string.IsNullOrWhiteSpace(fName))
                MessageBox.Show("Enter the users First Name");
            else if (string.IsNullOrWhiteSpace(lName))
                MessageBox.Show("Enter the users Last Name");
            else if (string.IsNullOrWhiteSpace(password))
                MessageBox.Show("Enter a Password");
            else if (insertRole == null)
                MessageBox.Show("Please select a Role");
            else
            {
                if (insertRole == "Customer Service")
                {
                    role = "custServ";
                }
                else if (insertRole == "Administrator")
                {
                    role = "admin";
                }
                else if (insertRole == "Maintenance")
                {
                    role = "maint";
                }

                userInsert(fName, lName, password, role);
            }
        }

        //This inserts the new user into the database based on the given information by the user
        private void userInsert(String fName, String lName, String password, String role)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");

            try
            {
                con.Open();
            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }

            string sql = "INSERT INTO dbo.Staff (firstName, lastName, password, role) VALUES (@fName, @lName, @password, @role)";
            using (var cmd = new SqlCommand(sql, con)) {

                cmd.Parameters.AddWithValue("@fName", fName);
                cmd.Parameters.AddWithValue("@lName", lName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                try{
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The user was Added Successfully");
                    AdminMenu admin = new AdminMenu();
                    this.Close();
                    this.Dispose();
                    admin.ShowDialog();

                } catch (Exception err) {
                    MessageBox.Show(err.Message);
                }

                try{
                    con.Close();
                }catch (Exception err){
                    MessageBox.Show(err.Message);
                }
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