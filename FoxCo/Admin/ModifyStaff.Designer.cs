namespace FoxCo.Admin
{
    partial class ModifyStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyStaff));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.buttonSelectStaff = new System.Windows.Forms.Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStaffID = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxStaffID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(307, 389);
            this.textBoxPassword.MaxLength = 60;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(229, 26);
            this.textBoxPassword.TabIndex = 27;
            this.textBoxPassword.Visible = false;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxLastName.Location = new System.Drawing.Point(307, 343);
            this.textBoxLastName.MaxLength = 25;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(229, 26);
            this.textBoxLastName.TabIndex = 26;
            this.textBoxLastName.Visible = false;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxFirstName.Location = new System.Drawing.Point(307, 298);
            this.textBoxFirstName.MaxLength = 25;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(229, 26);
            this.textBoxFirstName.TabIndex = 25;
            this.textBoxFirstName.Visible = false;
            this.textBoxFirstName.WordWrap = false;
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(307, 186);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(238, 28);
            this.comboBoxStaff.TabIndex = 24;
            this.comboBoxStaff.Text = "Please select a Staff Member";
            // 
            // buttonSelectStaff
            // 
            this.buttonSelectStaff.BackColor = System.Drawing.Color.Black;
            this.buttonSelectStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectStaff.ForeColor = System.Drawing.Color.White;
            this.buttonSelectStaff.Location = new System.Drawing.Point(396, 220);
            this.buttonSelectStaff.Name = "buttonSelectStaff";
            this.buttonSelectStaff.Size = new System.Drawing.Size(140, 50);
            this.buttonSelectStaff.TabIndex = 23;
            this.buttonSelectStaff.Text = "Select Staff Member";
            this.buttonSelectStaff.UseVisualStyleBackColor = false;
            this.buttonSelectStaff.Click += new System.EventHandler(this.buttonSelectStaff_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Black;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(560, 555);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(212, 16);
            this.labelCopyright.TabIndex = 22;
            this.labelCopyright.Text = "©Dundee and Angus College 2018";
            this.labelCopyright.UseWaitCursor = true;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Black;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(12, 555);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(41, 15);
            this.labelVersion.TabIndex = 21;
            this.labelVersion.Text = "label1";
            this.labelVersion.UseWaitCursor = true;
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.labelLoggedIn.ForeColor = System.Drawing.Color.White;
            this.labelLoggedIn.Location = new System.Drawing.Point(617, 52);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(65, 13);
            this.labelLoggedIn.TabIndex = 20;
            this.labelLoggedIn.Text = "PlaceHolder";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.White;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(272, 73);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(264, 31);
            this.labelLocation.TabIndex = 19;
            this.labelLocation.Text = "Modify Staff Account";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.White;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelDescription.Location = new System.Drawing.Point(87, 119);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(421, 24);
            this.labelDescription.TabIndex = 28;
            this.labelDescription.Text = "Please select a user to update from the list below.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(87, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "You may only make one selection";
            // 
            // labelStaffID
            // 
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.BackColor = System.Drawing.Color.White;
            this.labelStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelStaffID.Location = new System.Drawing.Point(177, 189);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(104, 20);
            this.labelStaffID.TabIndex = 30;
            this.labelStaffID.Text = "Staff ID List:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.White;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelFirstName.Location = new System.Drawing.Point(189, 298);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(92, 20);
            this.labelFirstName.TabIndex = 31;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.Visible = false;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.White;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelLastName.Location = new System.Drawing.Point(189, 343);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(91, 20);
            this.labelLastName.TabIndex = 32;
            this.labelLastName.Text = "Last Name";
            this.labelLastName.Visible = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.White;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelPassword.Location = new System.Drawing.Point(189, 392);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 20);
            this.labelPassword.TabIndex = 33;
            this.labelPassword.Text = "Password";
            this.labelPassword.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Black;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(223, 443);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 50);
            this.buttonUpdate.TabIndex = 34;
            this.buttonUpdate.Text = "Update User";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Black;
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(396, 443);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(140, 50);
            this.buttonReturn.TabIndex = 35;
            this.buttonReturn.Text = "Return to Previous Screen";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Visible = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // textBoxStaffID
            // 
            this.textBoxStaffID.Location = new System.Drawing.Point(620, 343);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStaffID.TabIndex = 36;
            this.textBoxStaffID.Visible = false;
            // 
            // ModifyStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.Controls.Add(this.textBoxStaffID);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.buttonSelectStaff);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.labelLocation);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 635);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 635);
            this.Name = "ModifyStaff";
            this.Text = "ModifyStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.Button buttonSelectStaff;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStaffID;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxStaffID;
    }
}