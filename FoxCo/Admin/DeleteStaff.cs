using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoxCo.Admin
{
    public partial class DeleteStaff : Form
    {
        private String dbConnection;
        private String version;

        public DeleteStaff()
        {
            InitializeComponent();
            startup();
            fillData();
        }

        private void startup()
        {
            ImportantCode test = new ImportantCode();
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            version = test.versionNumber();
            labelVersion.Text = version;
            dbConnection = test.dbConnection();
        }


        //This takes the staff members who are in the database and displays them within the Staff ComboBox for the user to select
        private void fillData()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            String query = "SELECT staffID, firstName, lastName FROM Staff";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxStaff.Items.Add(reader["staffID"].ToString() + "-" + reader["firstName"] + " " + reader["lastName"]);
                    }
                    reader.Close();
                }
                con.Close();
            }
        }

        //This takes the selected item in the ComboBox and splits it into the StaffID and Name, then passes the ID to the Confirm Delete function
        private void buttonSelectStaff_Click(object sender, EventArgs e)
        {
            if(comboBoxStaff.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Staff Member");
            } else
            {
                String[] staffString = comboBoxStaff.SelectedItem.ToString().Split('-');
                int staff = Int32.Parse(staffString[0]);
                confirmDelete(staffString[1], staff);
            }
            
        }

        //This asks the user to confirm the deletion of the Staff Member, if they select yes it then moves the user to the Delete Function
        private void confirmDelete(String name, int staffID)
        {
            if(staffID == userDetails.userID)
            {
                MessageBox.Show("You cannot delete your own user account");
            } else
            {
                string message = "Do you wish to delete the Staff Member ";
                string messageBoxName = "Delete Staff Member";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(this, message + name, messageBoxName, buttons);

                if (result == DialogResult.Yes)
                {
                    userDelete(staffID);
                }
            }
        }

        //This takes the StaffID that is passed through and deletes the user from the database, once this is complete it passes the user to the Admin Menu
        private void userDelete(int staffID)
        {
            String deleteQuery = "DELETE FROM Staff WHERE staffID = @StaffID";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30");
            using (SqlCommand delCommand = new SqlCommand(deleteQuery, con))
            {
                delCommand.Parameters.AddWithValue("@staffID", staffID);
                con.Open();
                delCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User has been deleted");
                AdminMenu create = new AdminMenu();
                this.Close();
                this.Dispose();
                create.ShowDialog();
            }
        }



        private void buttonReturn_Click(object sender, EventArgs e)
        {
            AdminMenu create = new AdminMenu();
            this.Close();
            this.Dispose();
            create.ShowDialog();
        }


        //Created by Accident
        private void labelLoggedIn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteStaff_Load(object sender, EventArgs e)
        {

        }
    }

}
