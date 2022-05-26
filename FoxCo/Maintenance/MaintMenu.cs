using System;
using System.Windows.Forms;

namespace FoxCo.Maintenance
{
    public partial class MaintMenu : Form
    {
        public MaintMenu()
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

        //This takes the user to the form to Review the maintenance checks
        private void buttonReview_Click(object sender, EventArgs e)
        {
            ReviewChecks review = new ReviewChecks();
            this.Close();
            this.Dispose();
            review.ShowDialog();
        }

        //This takes the user to the Main Menu
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            this.Dispose();
            menu.ShowDialog();
        }

        //This takes the user to the form to Update the maintenance checks
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateChecks update = new UpdateChecks();
            this.Close();
            this.Dispose();
            update.ShowDialog();
        }
    }
}
