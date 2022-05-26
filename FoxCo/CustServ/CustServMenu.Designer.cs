namespace FoxCo.CustServ
{
    partial class CustServMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustServMenu));
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonCreCustomer = new System.Windows.Forms.Button();
            this.buttonCreBooking = new System.Windows.Forms.Button();
            this.buttonDelBook = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonUpPassenger = new System.Windows.Forms.Button();
            this.buttonModBooking = new System.Windows.Forms.Button();
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
            this.labelCopyright.TabIndex = 26;
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
            this.labelVersion.TabIndex = 25;
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
            this.labelLoggedIn.TabIndex = 24;
            this.labelLoggedIn.Text = "PlaceHolder";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.White;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(270, 72);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(304, 31);
            this.labelLocation.TabIndex = 23;
            this.labelLocation.Text = "Customer Service Menu";
            // 
            // buttonCreCustomer
            // 
            this.buttonCreCustomer.BackColor = System.Drawing.Color.Black;
            this.buttonCreCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonCreCustomer.Location = new System.Drawing.Point(64, 185);
            this.buttonCreCustomer.Name = "buttonCreCustomer";
            this.buttonCreCustomer.Size = new System.Drawing.Size(173, 72);
            this.buttonCreCustomer.TabIndex = 27;
            this.buttonCreCustomer.Text = "Create a Customer";
            this.buttonCreCustomer.UseVisualStyleBackColor = false;
            this.buttonCreCustomer.Click += new System.EventHandler(this.buttonCreCustomer_Click);
            // 
            // buttonCreBooking
            // 
            this.buttonCreBooking.BackColor = System.Drawing.Color.Black;
            this.buttonCreBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreBooking.ForeColor = System.Drawing.Color.White;
            this.buttonCreBooking.Location = new System.Drawing.Point(64, 345);
            this.buttonCreBooking.Name = "buttonCreBooking";
            this.buttonCreBooking.Size = new System.Drawing.Size(173, 72);
            this.buttonCreBooking.TabIndex = 28;
            this.buttonCreBooking.Text = "Create a Booking";
            this.buttonCreBooking.UseVisualStyleBackColor = false;
            this.buttonCreBooking.Click += new System.EventHandler(this.buttonCreBooking_Click);
            // 
            // buttonDelBook
            // 
            this.buttonDelBook.BackColor = System.Drawing.Color.Black;
            this.buttonDelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelBook.ForeColor = System.Drawing.Color.White;
            this.buttonDelBook.Location = new System.Drawing.Point(330, 185);
            this.buttonDelBook.Name = "buttonDelBook";
            this.buttonDelBook.Size = new System.Drawing.Size(173, 72);
            this.buttonDelBook.TabIndex = 29;
            this.buttonDelBook.Text = "Delete Booking";
            this.buttonDelBook.UseVisualStyleBackColor = false;
            this.buttonDelBook.Click += new System.EventHandler(this.buttonDelBook_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Black;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(330, 345);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(173, 72);
            this.buttonReturn.TabIndex = 30;
            this.buttonReturn.Text = "Return to Previous page";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonUpPassenger
            // 
            this.buttonUpPassenger.BackColor = System.Drawing.Color.Black;
            this.buttonUpPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpPassenger.ForeColor = System.Drawing.Color.White;
            this.buttonUpPassenger.Location = new System.Drawing.Point(597, 185);
            this.buttonUpPassenger.Name = "buttonUpPassenger";
            this.buttonUpPassenger.Size = new System.Drawing.Size(173, 72);
            this.buttonUpPassenger.TabIndex = 31;
            this.buttonUpPassenger.Text = "Update Passenger";
            this.buttonUpPassenger.UseVisualStyleBackColor = false;
            this.buttonUpPassenger.Click += new System.EventHandler(this.buttonUpPassenger_Click);
            // 
            // buttonModBooking
            // 
            this.buttonModBooking.BackColor = System.Drawing.Color.Black;
            this.buttonModBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModBooking.ForeColor = System.Drawing.Color.White;
            this.buttonModBooking.Location = new System.Drawing.Point(597, 345);
            this.buttonModBooking.Name = "buttonModBooking";
            this.buttonModBooking.Size = new System.Drawing.Size(173, 72);
            this.buttonModBooking.TabIndex = 32;
            this.buttonModBooking.Text = "Modify Booking";
            this.buttonModBooking.UseVisualStyleBackColor = false;
            this.buttonModBooking.Click += new System.EventHandler(this.buttonModBooking_Click);
            // 
            // CustServMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.Controls.Add(this.buttonModBooking);
            this.Controls.Add(this.buttonUpPassenger);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonDelBook);
            this.Controls.Add(this.buttonCreBooking);
            this.Controls.Add(this.buttonCreCustomer);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.labelLocation);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 635);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 635);
            this.Name = "CustServMenu";
            this.Text = "CustServMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonCreCustomer;
        private System.Windows.Forms.Button buttonCreBooking;
        private System.Windows.Forms.Button buttonDelBook;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonUpPassenger;
        private System.Windows.Forms.Button buttonModBooking;
    }
}