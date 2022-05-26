namespace FoxCo.CustServ
{
    partial class ModifyBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyBooking));
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxBookingNumber = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.comboBoxFlights = new System.Windows.Forms.ComboBox();
            this.labelFlights = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.comboBoxRoute = new System.Windows.Forms.ComboBox();
            this.labelRoute = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelinfo3 = new System.Windows.Forms.Label();
            this.labelPassenger = new System.Windows.Forms.Label();
            this.labelpassengerName = new System.Windows.Forms.Label();
            this.labelseat = new System.Windows.Forms.Label();
            this.comboBoxSeatList = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Black;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(560, 557);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(212, 16);
            this.labelCopyright.TabIndex = 30;
            this.labelCopyright.Text = "©Dundee and Angus College 2018";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Black;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(12, 557);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(41, 15);
            this.labelVersion.TabIndex = 29;
            this.labelVersion.Text = "label1";
            this.labelVersion.UseWaitCursor = true;
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.labelLoggedIn.ForeColor = System.Drawing.Color.White;
            this.labelLoggedIn.Location = new System.Drawing.Point(617, 54);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(65, 13);
            this.labelLoggedIn.TabIndex = 28;
            this.labelLoggedIn.Text = "PlaceHolder";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.White;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(314, 71);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(199, 31);
            this.labelLocation.TabIndex = 27;
            this.labelLocation.Text = "Modify Booking";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Black;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(566, 114);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 27);
            this.buttonSearch.TabIndex = 39;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxBookingNumber
            // 
            this.textBoxBookingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookingNumber.Location = new System.Drawing.Point(400, 115);
            this.textBoxBookingNumber.MaxLength = 6;
            this.textBoxBookingNumber.Name = "textBoxBookingNumber";
            this.textBoxBookingNumber.Size = new System.Drawing.Size(139, 26);
            this.textBoxBookingNumber.TabIndex = 38;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.White;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(148, 118);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(255, 20);
            this.labelSearch.TabIndex = 37;
            this.labelSearch.Text = "Please enter the Booking Number: ";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.White;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(12, 163);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(433, 20);
            this.labelInfo.TabIndex = 40;
            this.labelInfo.Text = "Please select the updated route and flight for the Passenger";
            this.labelInfo.Visible = false;
            // 
            // comboBoxFlights
            // 
            this.comboBoxFlights.FormattingEnabled = true;
            this.comboBoxFlights.Location = new System.Drawing.Point(277, 245);
            this.comboBoxFlights.Name = "comboBoxFlights";
            this.comboBoxFlights.Size = new System.Drawing.Size(258, 21);
            this.comboBoxFlights.TabIndex = 59;
            this.comboBoxFlights.Text = "Please select the Required Flight";
            this.comboBoxFlights.Visible = false;
            this.comboBoxFlights.SelectedIndexChanged += new System.EventHandler(this.comboBoxFlights_SelectedIndexChanged);
            // 
            // labelFlights
            // 
            this.labelFlights.AutoSize = true;
            this.labelFlights.BackColor = System.Drawing.Color.White;
            this.labelFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlights.Location = new System.Drawing.Point(150, 245);
            this.labelFlights.Name = "labelFlights";
            this.labelFlights.Size = new System.Drawing.Size(120, 18);
            this.labelFlights.TabIndex = 58;
            this.labelFlights.Text = "Avaliable Flights: ";
            this.labelFlights.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.White;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(275, 286);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(86, 18);
            this.labelPrice.TabIndex = 57;
            this.labelPrice.Text = "Placeholder";
            this.labelPrice.Visible = false;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BackColor = System.Drawing.Color.White;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(150, 286);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(119, 18);
            this.labelCost.TabIndex = 56;
            this.labelCost.Text = "Cost Per Ticket: ";
            this.labelCost.Visible = false;
            // 
            // comboBoxRoute
            // 
            this.comboBoxRoute.FormattingEnabled = true;
            this.comboBoxRoute.Location = new System.Drawing.Point(237, 202);
            this.comboBoxRoute.Name = "comboBoxRoute";
            this.comboBoxRoute.Size = new System.Drawing.Size(247, 21);
            this.comboBoxRoute.TabIndex = 55;
            this.comboBoxRoute.Text = "Please select a Route";
            this.comboBoxRoute.Visible = false;
            this.comboBoxRoute.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoute_SelectedIndexChanged);
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.BackColor = System.Drawing.Color.White;
            this.labelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoute.Location = new System.Drawing.Point(149, 202);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(56, 18);
            this.labelRoute.TabIndex = 54;
            this.labelRoute.Text = "Route: ";
            this.labelRoute.Visible = false;
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.BackColor = System.Drawing.Color.White;
            this.labelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo2.Location = new System.Drawing.Point(12, 313);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(681, 18);
            this.labelInfo2.TabIndex = 60;
            this.labelInfo2.Text = "Next you will select a new seat for the named Passenger. If you wish to change th" +
    "e Passengers details,";
            this.labelInfo2.Visible = false;
            // 
            // labelinfo3
            // 
            this.labelinfo3.AutoSize = true;
            this.labelinfo3.BackColor = System.Drawing.Color.White;
            this.labelinfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfo3.Location = new System.Drawing.Point(12, 333);
            this.labelinfo3.Name = "labelinfo3";
            this.labelinfo3.Size = new System.Drawing.Size(307, 18);
            this.labelinfo3.TabIndex = 61;
            this.labelinfo3.Text = " please go to the Update Passengers  section";
            this.labelinfo3.Visible = false;
            // 
            // labelPassenger
            // 
            this.labelPassenger.AutoSize = true;
            this.labelPassenger.BackColor = System.Drawing.Color.White;
            this.labelPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassenger.Location = new System.Drawing.Point(151, 364);
            this.labelPassenger.Name = "labelPassenger";
            this.labelPassenger.Size = new System.Drawing.Size(87, 18);
            this.labelPassenger.TabIndex = 62;
            this.labelPassenger.Text = "Passenger: ";
            this.labelPassenger.Visible = false;
            // 
            // labelpassengerName
            // 
            this.labelpassengerName.AutoSize = true;
            this.labelpassengerName.BackColor = System.Drawing.Color.White;
            this.labelpassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassengerName.Location = new System.Drawing.Point(234, 364);
            this.labelpassengerName.Name = "labelpassengerName";
            this.labelpassengerName.Size = new System.Drawing.Size(86, 18);
            this.labelpassengerName.TabIndex = 63;
            this.labelpassengerName.Text = "Placeholder";
            this.labelpassengerName.Visible = false;
            // 
            // labelseat
            // 
            this.labelseat.AutoSize = true;
            this.labelseat.BackColor = System.Drawing.Color.White;
            this.labelseat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseat.Location = new System.Drawing.Point(152, 398);
            this.labelseat.Name = "labelseat";
            this.labelseat.Size = new System.Drawing.Size(46, 18);
            this.labelseat.TabIndex = 64;
            this.labelseat.Text = "Seat: ";
            this.labelseat.Visible = false;
            // 
            // comboBoxSeatList
            // 
            this.comboBoxSeatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeatList.FormattingEnabled = true;
            this.comboBoxSeatList.Location = new System.Drawing.Point(197, 395);
            this.comboBoxSeatList.Name = "comboBoxSeatList";
            this.comboBoxSeatList.Size = new System.Drawing.Size(203, 26);
            this.comboBoxSeatList.TabIndex = 65;
            this.comboBoxSeatList.Text = "Please select a seat";
            this.comboBoxSeatList.Visible = false;
            this.comboBoxSeatList.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeatList_SelectedIndexChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Black;
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(119, 465);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(150, 39);
            this.buttonSubmit.TabIndex = 66;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Black;
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(503, 465);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(150, 39);
            this.buttonReturn.TabIndex = 67;
            this.buttonReturn.Text = "Return to Previous Menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // ModifyBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxSeatList);
            this.Controls.Add(this.labelseat);
            this.Controls.Add(this.labelpassengerName);
            this.Controls.Add(this.labelPassenger);
            this.Controls.Add(this.labelinfo3);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.comboBoxFlights);
            this.Controls.Add(this.labelFlights);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.comboBoxRoute);
            this.Controls.Add(this.labelRoute);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxBookingNumber);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.labelLocation);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 635);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 635);
            this.Name = "ModifyBooking";
            this.Text = "ModifyBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxBookingNumber;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ComboBox comboBoxFlights;
        private System.Windows.Forms.Label labelFlights;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.ComboBox comboBoxRoute;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelinfo3;
        private System.Windows.Forms.Label labelPassenger;
        private System.Windows.Forms.Label labelpassengerName;
        private System.Windows.Forms.Label labelseat;
        private System.Windows.Forms.ComboBox comboBoxSeatList;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReturn;
    }
}