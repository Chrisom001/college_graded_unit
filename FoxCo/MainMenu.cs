using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoxCo
{
    public partial class MainMenu : Form
    {
        private String dbConnection;
        private String version;
        private String userName = "";

        public MainMenu(int staffID)
        {
            InitializeComponent();
            startup(staffID);
        }

        public MainMenu()
        {
            InitializeComponent();
            startup();
        }

        // When the user first logs in, this checks the User ID against hte Staff Table
        // it then updates the Staff ID and Username in the User Details class
        private void userCheck(int staffID)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+dbConnection+";Integrated Security=True;Connect Timeout=30");
            con.Open();
            String query = "SELECT firstName FROM Staff WHERE staffID = @staffId";
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@staffId", staffID);
                userName = (String)cmd.ExecuteScalar();
                labelLoggedIn.Text = "You are logged in as " + userName;
            }
            con.Close();
            userDetails.userID = staffID;
            userDetails.userName = userName;
            roleCheck(staffID);
        }

        // When the user first logs in, this is run in order to check for the users
        // Name, Role and enable the relevant buttons
        private void startup(int staffID)
        {
            ImportantCode test = new ImportantCode();
            version = test.versionNumber();
            labelVersion.Text = version;
            dbConnection = test.dbConnection();
            userCheck(staffID);
        }

        //When the user navigates to the Main Menu from the sub menus, this takes the details
        //that were stored in User Details and then uses it to enable the relevant buttons.
        private void startup()
        {
            ImportantCode test = new ImportantCode();
            version = test.versionNumber();
            labelVersion.Text = version;
            dbConnection = test.dbConnection();
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            buttonUpdate();
        }

        // When the user first logs in, this checks for their role based on their ID. 
        // It then enables the relevant buttons for the user and also updates their
        // role in the User Details class.
        private void roleCheck(int staffID)
        {

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename ="+dbConnection+"; Integrated Security = True; Connect Timeout = 30");
            con.Open();
            String query = "SELECT role FROM Staff WHERE staffID = @staffId";
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@staffId", staffID);
                userDetails.role = (String)cmd.ExecuteScalar();
            }
            con.Close();
            if (userDetails.role == "admin")
            {
                buttonAdmin.Enabled = true;
                buttonCustService.Enabled = true;
                buttonMaintenance.Enabled = true;
            } else if (userDetails.role == "custServ")
            {
                buttonCustService.Enabled = true;
                buttonAdmin.BackColor = Color.Gray;
                buttonAdmin.ForeColor = Color.Black;
                buttonMaintenance.BackColor = Color.Gray;
                buttonAdmin.ForeColor = Color.Black;
            } else if (userDetails.role == "maint")
            {
                buttonMaintenance.Enabled = true;
                buttonAdmin.BackColor = Color.Gray;
                buttonAdmin.ForeColor = Color.Black;
                buttonCustService.BackColor = Color.Gray;
                buttonCustService.ForeColor = Color.Black;
            }
        }
        // This button takes the user to the Admin Main Menu
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Admin.AdminMenu admin = new Admin.AdminMenu();
            this.Close();
            this.Dispose();
            admin.ShowDialog();
        }

        //This checks the users role and enables the buttons relevant to their job role.
        private void buttonUpdate()
        {
            if (userDetails.role == "admin")
            {
                buttonAdmin.Enabled = true;
                buttonCustService.Enabled = true;
                buttonMaintenance.Enabled = true;
            }
            else if (userDetails.role == "custServ")
            {
                buttonCustService.Enabled = true;
                buttonAdmin.BackColor = Color.Gray;
                buttonAdmin.ForeColor = Color.Black;
                buttonMaintenance.BackColor = Color.Gray;
                buttonAdmin.ForeColor = Color.Black;
            }
            else if (userDetails.role == "maint")
            {
                buttonMaintenance.Enabled = true;
                buttonAdmin.BackColor = Color.Gray;
                buttonAdmin.ForeColor = Color.Black;
                buttonCustService.BackColor = Color.Gray;
                buttonCustService.ForeColor = Color.Black;
            }
        }

        // This button takes the user to the Customer Service Main Menu

        private void buttonCustService_Click(object sender, EventArgs e)
        {
            CustServ.CustServMenu Cust = new CustServ.CustServMenu();
            this.Close();
            this.Dispose();
            Cust.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // This button takes the user to the Maintenance Main Menu
        private void buttonMaintenance_Click(object sender, EventArgs e)
        {
            Maintenance.MaintMenu maint = new Maintenance.MaintMenu();
            this.Close();
            this.Dispose();
            maint.ShowDialog();
        }

        //This takes the user back to the Login Screen and wipes the details stored in the
        // user details class.
        private void buttonLogOff_Click(object sender, EventArgs e)
        {
            userDetails.role = "";
            userDetails.userName = "";
            userDetails.userID = 0;

            loginScreen login = new loginScreen();
            this.Close();
            this.Dispose();
            login.ShowDialog();
        }
    }
}
