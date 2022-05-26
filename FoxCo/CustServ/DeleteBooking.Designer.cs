namespace FoxCo.CustServ
{
    partial class DeleteBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBooking));
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxBookingNumber = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelBookNumInfo = new System.Windows.Forms.Label();
            this.labelCustNameInfo = new System.Windows.Forms.Label();
            this.labelPassNameInfo = new System.Windows.Forms.Label();
            this.labelBookingNumber = new System.Windows.Forms.Label();
            this.labelSeatNumInfo = new System.Windows.Forms.Label();
            this.labelCustName = new System.Windows.Forms.Label();
            this.labelPassName = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
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
            this.labelLocation.Location = new System.Drawing.Point(315, 71);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(198, 31);
            this.labelLocation.TabIndex = 27;
            this.labelLocation.Text = "Delete Booking";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.White;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(54, 160);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(255, 20);
            this.labelSearch.TabIndex = 31;
            this.labelSearch.Text = "Please enter the Booking Number: ";
            // 
            // textBoxBookingNumber
            // 
            this.textBoxBookingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookingNumber.Location = new System.Drawing.Point(306, 157);
            this.textBoxBookingNumber.MaxLength = 6;
            this.textBoxBookingNumber.Name = "textBoxBookingNumber";
            this.textBoxBookingNumber.Size = new System.Drawing.Size(139, 26);
            this.textBoxBookingNumber.TabIndex = 32;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Black;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(472, 156);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 27);
            this.buttonSearch.TabIndex = 33;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelBookNumInfo
            // 
            this.labelBookNumInfo.AutoSize = true;
            this.labelBookNumInfo.BackColor = System.Drawing.Color.White;
            this.labelBookNumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookNumInfo.Location = new System.Drawing.Point(12, 219);
            this.labelBookNumInfo.Name = "labelBookNumInfo";
            this.labelBookNumInfo.Size = new System.Drawing.Size(120, 18);
            this.labelBookNumInfo.TabIndex = 34;
            this.labelBookNumInfo.Text = "Booking Number";
            this.labelBookNumInfo.Visible = false;
            // 
            // labelCustNameInfo
            // 
            this.labelCustNameInfo.AutoSize = true;
            this.labelCustNameInfo.BackColor = System.Drawing.Color.White;
            this.labelCustNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustNameInfo.Location = new System.Drawing.Point(149, 219);
            this.labelCustNameInfo.Name = "labelCustNameInfo";
            this.labelCustNameInfo.Size = new System.Drawing.Size(118, 18);
            this.labelCustNameInfo.TabIndex = 35;
            this.labelCustNameInfo.Text = "Customer Name";
            this.labelCustNameInfo.Visible = false;
            // 
            // labelPassNameInfo
            // 
            this.labelPassNameInfo.AutoSize = true;
            this.labelPassNameInfo.BackColor = System.Drawing.Color.White;
            this.labelPassNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassNameInfo.Location = new System.Drawing.Point(378, 219);
            this.labelPassNameInfo.Name = "labelPassNameInfo";
            this.labelPassNameInfo.Size = new System.Drawing.Size(123, 18);
            this.labelPassNameInfo.TabIndex = 36;
            this.labelPassNameInfo.Text = "Passenger Name";
            this.labelPassNameInfo.Visible = false;
            // 
            // labelBookingNumber
            // 
            this.labelBookingNumber.AutoSize = true;
            this.labelBookingNumber.BackColor = System.Drawing.Color.White;
            this.labelBookingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingNumber.Location = new System.Drawing.Point(12, 260);
            this.labelBookingNumber.Name = "labelBookingNumber";
            this.labelBookingNumber.Size = new System.Drawing.Size(86, 18);
            this.labelBookingNumber.TabIndex = 37;
            this.labelBookingNumber.Text = "Placeholder";
            this.labelBookingNumber.Visible = false;
            // 
            // labelSeatNumInfo
            // 
            this.labelSeatNumInfo.AutoSize = true;
            this.labelSeatNumInfo.BackColor = System.Drawing.Color.White;
            this.labelSeatNumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatNumInfo.Location = new System.Drawing.Point(652, 219);
            this.labelSeatNumInfo.Name = "labelSeatNumInfo";
            this.labelSeatNumInfo.Size = new System.Drawing.Size(95, 18);
            this.labelSeatNumInfo.TabIndex = 38;
            this.labelSeatNumInfo.Text = "Seat Number";
            this.labelSeatNumInfo.Visible = false;
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.BackColor = System.Drawing.Color.White;
            this.labelCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustName.Location = new System.Drawing.Point(152, 260);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(86, 18);
            this.labelCustName.TabIndex = 39;
            this.labelCustName.Text = "Placeholder";
            this.labelCustName.Visible = false;
            // 
            // labelPassName
            // 
            this.labelPassName.AutoSize = true;
            this.labelPassName.BackColor = System.Drawing.Color.White;
            this.labelPassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassName.Location = new System.Drawing.Point(381, 260);
            this.labelPassName.Name = "labelPassName";
            this.labelPassName.Size = new System.Drawing.Size(86, 18);
            this.labelPassName.TabIndex = 40;
            this.labelPassName.Text = "Placeholder";
            this.labelPassName.Visible = false;
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.BackColor = System.Drawing.Color.White;
            this.labelSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeat.Location = new System.Drawing.Point(651, 260);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(86, 18);
            this.labelSeat.TabIndex = 41;
            this.labelSeat.Text = "Placeholder";
            this.labelSeat.Visible = false;
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.BackColor = System.Drawing.Color.White;
            this.labelInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo1.Location = new System.Drawing.Point(15, 330);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(636, 20);
            this.labelInfo1.TabIndex = 42;
            this.labelInfo1.Text = "If these details are correct, please hit the submit button to delete the customer" +
    "s booking. ";
            this.labelInfo1.Visible = false;
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.BackColor = System.Drawing.Color.White;
            this.labelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo2.Location = new System.Drawing.Point(15, 350);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(300, 20);
            this.labelInfo2.TabIndex = 43;
            this.labelInfo2.Text = "This will also delete the passenger as well";
            this.labelInfo2.Visible = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Black;
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(19, 427);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(150, 40);
            this.buttonSubmit.TabIndex = 44;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Black;
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(572, 427);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(150, 40);
            this.buttonReturn.TabIndex = 45;
            this.buttonReturn.Text = "Return to Previous Menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // DeleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.labelPassName);
            this.Controls.Add(this.labelCustName);
            this.Controls.Add(this.labelSeatNumInfo);
            this.Controls.Add(this.labelBookingNumber);
            this.Controls.Add(this.labelPassNameInfo);
            this.Controls.Add(this.labelCustNameInfo);
            this.Controls.Add(this.labelBookNumInfo);
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
            this.Name = "DeleteBooking";
            this.Text = "DeleteBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxBookingNumber;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelBookNumInfo;
        private System.Windows.Forms.Label labelCustNameInfo;
        private System.Windows.Forms.Label labelPassNameInfo;
        private System.Windows.Forms.Label labelBookingNumber;
        private System.Windows.Forms.Label labelSeatNumInfo;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.Label labelPassName;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReturn;
    }
}