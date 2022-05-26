namespace FoxCo.CustServ
{
    partial class UpdatePassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassenger));
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxBookingNumber = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelPrevious = new System.Windows.Forms.Label();
            this.labelNew = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.labelFirstNamePrev = new System.Windows.Forms.Label();
            this.labelLastNamePrev = new System.Windows.Forms.Label();
            this.labelSeatPrev = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxSeat = new System.Windows.Forms.ComboBox();
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
            this.labelCopyright.Location = new System.Drawing.Point(560, 558);
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
            this.labelVersion.Location = new System.Drawing.Point(12, 558);
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
            this.labelLoggedIn.Location = new System.Drawing.Point(617, 55);
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
            this.labelLocation.Location = new System.Drawing.Point(253, 74);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(330, 31);
            this.labelLocation.TabIndex = 27;
            this.labelLocation.Text = "Update Passenger Details";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Black;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(529, 137);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 27);
            this.buttonSearch.TabIndex = 36;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxBookingNumber
            // 
            this.textBoxBookingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookingNumber.Location = new System.Drawing.Point(363, 138);
            this.textBoxBookingNumber.MaxLength = 6;
            this.textBoxBookingNumber.Name = "textBoxBookingNumber";
            this.textBoxBookingNumber.Size = new System.Drawing.Size(139, 26);
            this.textBoxBookingNumber.TabIndex = 35;
            this.textBoxBookingNumber.TextChanged += new System.EventHandler(this.textBoxBookingNumber_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.White;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(111, 141);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(255, 20);
            this.labelSearch.TabIndex = 34;
            this.labelSearch.Text = "Please enter the Booking Number: ";
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.White;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(56, 191);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(669, 20);
            this.labelInfo.TabIndex = 37;
            this.labelInfo.Text = "Please enter the updated details for the customer below and when they are correct" +
    ", hit Submit";
            this.labelInfo.Visible = false;
            // 
            // labelPrevious
            // 
            this.labelPrevious.AutoSize = true;
            this.labelPrevious.BackColor = System.Drawing.Color.White;
            this.labelPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrevious.Location = new System.Drawing.Point(125, 238);
            this.labelPrevious.Name = "labelPrevious";
            this.labelPrevious.Size = new System.Drawing.Size(122, 20);
            this.labelPrevious.TabIndex = 38;
            this.labelPrevious.Text = "Previous Details";
            this.labelPrevious.Visible = false;
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.BackColor = System.Drawing.Color.White;
            this.labelNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNew.Location = new System.Drawing.Point(525, 238);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(93, 20);
            this.labelNew.TabIndex = 39;
            this.labelNew.Text = "New Details";
            this.labelNew.Visible = false;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.White;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(12, 286);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(81, 18);
            this.labelFirstName.TabIndex = 40;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.Visible = false;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.White;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(13, 336);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(80, 18);
            this.labelLastName.TabIndex = 41;
            this.labelLastName.Text = "Last Name";
            this.labelLastName.Visible = false;
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.BackColor = System.Drawing.Color.White;
            this.labelSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeat.Location = new System.Drawing.Point(15, 389);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(38, 18);
            this.labelSeat.TabIndex = 42;
            this.labelSeat.Text = "Seat";
            this.labelSeat.Visible = false;
            // 
            // labelFirstNamePrev
            // 
            this.labelFirstNamePrev.AutoSize = true;
            this.labelFirstNamePrev.BackColor = System.Drawing.Color.White;
            this.labelFirstNamePrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNamePrev.Location = new System.Drawing.Point(126, 286);
            this.labelFirstNamePrev.Name = "labelFirstNamePrev";
            this.labelFirstNamePrev.Size = new System.Drawing.Size(86, 18);
            this.labelFirstNamePrev.TabIndex = 43;
            this.labelFirstNamePrev.Text = "Placeholder";
            this.labelFirstNamePrev.Visible = false;
            // 
            // labelLastNamePrev
            // 
            this.labelLastNamePrev.AutoSize = true;
            this.labelLastNamePrev.BackColor = System.Drawing.Color.White;
            this.labelLastNamePrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastNamePrev.Location = new System.Drawing.Point(126, 336);
            this.labelLastNamePrev.Name = "labelLastNamePrev";
            this.labelLastNamePrev.Size = new System.Drawing.Size(86, 18);
            this.labelLastNamePrev.TabIndex = 44;
            this.labelLastNamePrev.Text = "Placeholder";
            this.labelLastNamePrev.Visible = false;
            // 
            // labelSeatPrev
            // 
            this.labelSeatPrev.AutoSize = true;
            this.labelSeatPrev.BackColor = System.Drawing.Color.White;
            this.labelSeatPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatPrev.Location = new System.Drawing.Point(129, 393);
            this.labelSeatPrev.Name = "labelSeatPrev";
            this.labelSeatPrev.Size = new System.Drawing.Size(86, 18);
            this.labelSeatPrev.TabIndex = 45;
            this.labelSeatPrev.Text = "Placeholder";
            this.labelSeatPrev.Visible = false;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(474, 283);
            this.textBoxFirstName.MaxLength = 25;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(208, 24);
            this.textBoxFirstName.TabIndex = 46;
            this.textBoxFirstName.Visible = false;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(474, 332);
            this.textBoxLastName.MaxLength = 25;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(208, 24);
            this.textBoxLastName.TabIndex = 47;
            this.textBoxLastName.Visible = false;
            // 
            // comboBoxSeat
            // 
            this.comboBoxSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeat.FormattingEnabled = true;
            this.comboBoxSeat.Location = new System.Drawing.Point(474, 388);
            this.comboBoxSeat.Name = "comboBoxSeat";
            this.comboBoxSeat.Size = new System.Drawing.Size(208, 26);
            this.comboBoxSeat.TabIndex = 48;
            this.comboBoxSeat.Text = "Please select a Seat";
            this.comboBoxSeat.Visible = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Black;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(140, 454);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(160, 45);
            this.buttonSubmit.TabIndex = 49;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Black;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(474, 454);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(160, 45);
            this.buttonReturn.TabIndex = 50;
            this.buttonReturn.Text = "Return to Previous Menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // UpdatePassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxSeat);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelSeatPrev);
            this.Controls.Add(this.labelLastNamePrev);
            this.Controls.Add(this.labelFirstNamePrev);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelNew);
            this.Controls.Add(this.labelPrevious);
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
            this.Name = "UpdatePassenger";
            this.Text = "UpdatePassenger";
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
        private System.Windows.Forms.Label labelPrevious;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.Label labelFirstNamePrev;
        private System.Windows.Forms.Label labelLastNamePrev;
        private System.Windows.Forms.Label labelSeatPrev;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxSeat;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReturn;
    }
}