using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoxCo.Admin
{
    public partial class ModifyStaff : Form
    {
        private String dbConnection;
        private String version;

        public ModifyStaff()
        {
            InitializeComponent();
            startup();
            fillData();
        }

        //This checks that there was a user selected and if not then it returns an error
        //If there was, it takes the ID and makes the old and new boxes visible to the user
        //And fills the labels with the old information from the database.
        private void buttonSelectStaff_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM Staff where staffID = @staffID";
            
            if (comboBoxStaff.SelectedIndex != -1)
            {
                String[] staffChoice = comboBoxStaff.SelectedItem.ToString().Split('-');
                int staff = Int32.Parse(staffChoice[0]);
                labelStaffID.Visible = false;
                comboBoxStaff.Visible = false;
                buttonSelectStaff.Visible = false;
                textBoxFirstName.Visible = true;
                textBoxLastName.Visible = true;
                textBoxPassword.Visible = true;
                labelFirstName.Visible = true;
                labelLastName.Visible = true;
                labelPassword.Visible = true;
                buttonUpdate.Visible = true;
                buttonReturn.Visible = true;

                using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + dbConnection + "; Integrated Security = True; Connect Timeout = 30"))
                {
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@staffID", staff);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                textBoxFirstName.Text = reader["firstName"].ToString();
                                textBoxLastName.Text = reader["lastName"].ToString();
                                textBoxPassword.Text = reader["password"].ToString();
                                textBoxStaffID.Text = staff.ToString();
                            }
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Please select a Staff Member to modify");
            }
            
        }
        //This fills the comboBox with all the staff data that is in the database to allow the user to pick a single member of staff
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
                        comboBoxStaff.Items.Add(reader["staffID"].ToString() + "-" + reader["firstName"].ToString() + " " + reader["lastName"].ToString());
                    }
                    reader.Close();
                }
                con.Close();
            }
        }

        private void startup()
        {
            ImportantCode test = new ImportantCode();
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            version = test.versionNumber();
            labelVersion.Text = version;
            dbConnection = test.dbConnection();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            AdminMenu create = new AdminMenu();
            this.Close();
            this.Dispose();
            create.ShowDialog();
        }

        //This checks that the staffID given was valid, if not it sends an error otherwise it moves to the EmptyCheck function
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            String fName = textBoxFirstName.Text;
            String lName = textBoxLastName.Text;
            String password = textBoxPassword.Text;
            int staffID;
            bool parsed = Int32.TryParse(textBoxStaffID.Text, out staffID);
            if (parsed)
                emptyCheck(fName, lName, password, staffID);
            else
                MessageBox.Show("There was a problem with that Staff ID");
        }

        //This checks to ensure that the fields are filled by data by the user otherwise it returns an error
        private void emptyCheck(String fName, String lName, String password, int staffID)
        {
            if (string.IsNullOrWhiteSpace(fName))
                MessageBox.Show("Enter the users First Name");
            else if (string.IsNullOrWhiteSpace(lName))
                MessageBox.Show("Enter the users Last Name");
            else if (string.IsNullOrWhiteSpace(password))
                MessageBox.Show("Enter a Password");
            else
                userUpdate(fName, lName, password, staffID);
        }

        //This takes the provided Name, Password and Staff ID and updates the database for that member of staff
        private void userUpdate(String fName, String lName, String password, int staffID)
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

            string sql = "UPDATE Staff set firstName = @fName, lastName = @lName, password = @password WHERE staffID = @staffID";
            using (var cmd = new SqlCommand(sql, con))
            {

                cmd.Parameters.AddWithValue("@fName", fName);
                cmd.Parameters.AddWithValue("@lName", lName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@staffID", staffID);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The user was updated successfully");

                    AdminMenu create = new AdminMenu();
                    this.Close();
                    this.Dispose();
                    create.ShowDialog();
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
    }
}
