using System;
using System.Windows.Forms;

namespace FoxCo.CustServ
{
    public partial class CustServMenu : Form
    {
        public CustServMenu()
        {
            InitializeComponent();
            startup();
        }

        public void startup()
        {
            labelLoggedIn.Text = "You are logged in as " + userDetails.userName;
            ImportantCode test = new ImportantCode();
            String version = test.versionNumber();
            labelVersion.Text = version;
        }

        //This takes the user back to the main menu
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }
        //This takes the user to the form to create a new customer
        private void buttonCreCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomer create = new CreateCustomer();
            this.Close();
            this.Dispose();
            create.ShowDialog();
        }
        //This takes the user to the form to create a new booking
        private void buttonCreBooking_Click(object sender, EventArgs e)
        {
            CreateBooking create = new CreateBooking();
            this.Close();
            this.Dispose();
            create.ShowDialog();
        }
        //This takes the user to the form to delete a booking
        private void buttonDelBook_Click(object sender, EventArgs e)
        {
            DeleteBooking delete = new DeleteBooking();
            this.Close();
            this.Dispose();
            delete.ShowDialog();
        }
        //This takes the user to the form to update a passengers details
        private void buttonUpPassenger_Click(object sender, EventArgs e)
        {
            UpdatePassenger update = new UpdatePassenger();
            this.Close();
            this.Dispose();
            update.ShowDialog();
        }
        //This takes the user to the form to modify a customers bookings
        private void buttonModBooking_Click(object sender, EventArgs e)
        {
            ModifyBooking mod = new ModifyBooking();
            this.Close();
            this.Dispose();
            mod.ShowDialog();
        }
    }
}
