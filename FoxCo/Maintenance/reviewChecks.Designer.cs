namespace FoxCo.Maintenance
{
    partial class ReviewChecks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewChecks));
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.comboBoxAircraft = new System.Windows.Forms.ComboBox();
            this.labelAcheck = new System.Windows.Forms.Label();
            this.labelBcheck = new System.Windows.Forms.Label();
            this.labelCcheck = new System.Windows.Forms.Label();
            this.labelDcheck = new System.Windows.Forms.Label();
            this.labelAcheckInfo = new System.Windows.Forms.Label();
            this.labelBcheckInfo = new System.Windows.Forms.Label();
            this.labelCcheckInfo = new System.Windows.Forms.Label();
            this.labelDcheckInfo = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelAircraftType = new System.Windows.Forms.Label();
            this.labelAirTypeInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Black;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(560, 556);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(212, 16);
            this.labelCopyright.TabIndex = 19;
            this.labelCopyright.Text = "©Dundee and Angus College 2018";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Black;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(12, 556);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(41, 15);
            this.labelVersion.TabIndex = 18;
            this.labelVersion.Text = "label1";
            this.labelVersion.UseWaitCursor = true;
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.labelLoggedIn.ForeColor = System.Drawing.Color.White;
            this.labelLoggedIn.Location = new System.Drawing.Point(617, 53);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(65, 13);
            this.labelLoggedIn.TabIndex = 17;
            this.labelLoggedIn.Text = "PlaceHolder";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.White;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(271, 70);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(297, 31);
            this.labelLocation.TabIndex = 16;
            this.labelLocation.Text = "Review Aircraft Checks";
            // 
            // comboBoxAircraft
            // 
            this.comboBoxAircraft.FormattingEnabled = true;
            this.comboBoxAircraft.Location = new System.Drawing.Point(298, 125);
            this.comboBoxAircraft.Name = "comboBoxAircraft";
            this.comboBoxAircraft.Size = new System.Drawing.Size(237, 21);
            this.comboBoxAircraft.TabIndex = 20;
            this.comboBoxAircraft.Text = "Please select an Aircraft";
            // 
            // labelAcheck
            // 
            this.labelAcheck.AutoSize = true;
            this.labelAcheck.BackColor = System.Drawing.Color.White;
            this.labelAcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcheck.Location = new System.Drawing.Point(313, 239);
            this.labelAcheck.Name = "labelAcheck";
            this.labelAcheck.Size = new System.Drawing.Size(104, 18);
            this.labelAcheck.TabIndex = 21;
            this.labelAcheck.Text = "Last A Check: ";
            this.labelAcheck.Visible = false;
            // 
            // labelBcheck
            // 
            this.labelBcheck.AutoSize = true;
            this.labelBcheck.BackColor = System.Drawing.Color.White;
            this.labelBcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBcheck.Location = new System.Drawing.Point(312, 280);
            this.labelBcheck.Name = "labelBcheck";
            this.labelBcheck.Size = new System.Drawing.Size(105, 18);
            this.labelBcheck.TabIndex = 22;
            this.labelBcheck.Text = "Last B Check: ";
            this.labelBcheck.Visible = false;
            // 
            // labelCcheck
            // 
            this.labelCcheck.AutoSize = true;
            this.labelCcheck.BackColor = System.Drawing.Color.White;
            this.labelCcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCcheck.Location = new System.Drawing.Point(311, 318);
            this.labelCcheck.Name = "labelCcheck";
            this.labelCcheck.Size = new System.Drawing.Size(106, 18);
            this.labelCcheck.TabIndex = 23;
            this.labelCcheck.Text = "Last C Check: ";
            this.labelCcheck.Visible = false;
            // 
            // labelDcheck
            // 
            this.labelDcheck.AutoSize = true;
            this.labelDcheck.BackColor = System.Drawing.Color.White;
            this.labelDcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcheck.Location = new System.Drawing.Point(311, 355);
            this.labelDcheck.Name = "labelDcheck";
            this.labelDcheck.Size = new System.Drawing.Size(106, 18);
            this.labelDcheck.TabIndex = 24;
            this.labelDcheck.Text = "Last D Check: ";
            this.labelDcheck.Visible = false;
            // 
            // labelAcheckInfo
            // 
            this.labelAcheckInfo.AutoSize = true;
            this.labelAcheckInfo.BackColor = System.Drawing.Color.White;
            this.labelAcheckInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcheckInfo.Location = new System.Drawing.Point(433, 239);
            this.labelAcheckInfo.Name = "labelAcheckInfo";
            this.labelAcheckInfo.Size = new System.Drawing.Size(86, 18);
            this.labelAcheckInfo.TabIndex = 25;
            this.labelAcheckInfo.Text = "Placeholder";
            this.labelAcheckInfo.Visible = false;
            // 
            // labelBcheckInfo
            // 
            this.labelBcheckInfo.AutoSize = true;
            this.labelBcheckInfo.BackColor = System.Drawing.Color.White;
            this.labelBcheckInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBcheckInfo.Location = new System.Drawing.Point(433, 280);
            this.labelBcheckInfo.Name = "labelBcheckInfo";
            this.labelBcheckInfo.Size = new System.Drawing.Size(86, 18);
            this.labelBcheckInfo.TabIndex = 26;
            this.labelBcheckInfo.Text = "Placeholder";
            this.labelBcheckInfo.Visible = false;
            // 
            // labelCcheckInfo
            // 
            this.labelCcheckInfo.AutoSize = true;
            this.labelCcheckInfo.BackColor = System.Drawing.Color.White;
            this.labelCcheckInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCcheckInfo.Location = new System.Drawing.Point(433, 318);
            this.labelCcheckInfo.Name = "labelCcheckInfo";
            this.labelCcheckInfo.Size = new System.Drawing.Size(86, 18);
            this.labelCcheckInfo.TabIndex = 27;
            this.labelCcheckInfo.Text = "Placeholder";
            this.labelCcheckInfo.Visible = false;
            // 
            // labelDcheckInfo
            // 
            this.labelDcheckInfo.AutoSize = true;
            this.labelDcheckInfo.BackColor = System.Drawing.Color.White;
            this.labelDcheckInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcheckInfo.Location = new System.Drawing.Point(433, 355);
            this.labelDcheckInfo.Name = "labelDcheckInfo";
            this.labelDcheckInfo.Size = new System.Drawing.Size(86, 18);
            this.labelDcheckInfo.TabIndex = 28;
            this.labelDcheckInfo.Text = "Placeholder";
            this.labelDcheckInfo.Visible = false;
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.Black;
            this.buttonSelect.ForeColor = System.Drawing.Color.White;
            this.buttonSelect.Location = new System.Drawing.Point(460, 152);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 29;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Black;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(277, 401);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(140, 50);
            this.buttonReturn.TabIndex = 30;
            this.buttonReturn.Text = "Return to Menu";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Black;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(436, 401);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 50);
            this.buttonUpdate.TabIndex = 31;
            this.buttonUpdate.Text = "Update Checks";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelAircraftType
            // 
            this.labelAircraftType.AutoSize = true;
            this.labelAircraftType.BackColor = System.Drawing.Color.White;
            this.labelAircraftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAircraftType.Location = new System.Drawing.Point(313, 204);
            this.labelAircraftType.Name = "labelAircraftType";
            this.labelAircraftType.Size = new System.Drawing.Size(98, 18);
            this.labelAircraftType.TabIndex = 32;
            this.labelAircraftType.Text = "Aircraft Type: ";
            this.labelAircraftType.Visible = false;
            // 
            // labelAirTypeInfo
            // 
            this.labelAirTypeInfo.AutoSize = true;
            this.labelAirTypeInfo.BackColor = System.Drawing.Color.White;
            this.labelAirTypeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAirTypeInfo.Location = new System.Drawing.Point(433, 204);
            this.labelAirTypeInfo.Name = "labelAirTypeInfo";
            this.labelAirTypeInfo.Size = new System.Drawing.Size(86, 18);
            this.labelAirTypeInfo.TabIndex = 33;
            this.labelAirTypeInfo.Text = "Placeholder";
            this.labelAirTypeInfo.Visible = false;
            // 
            // ReviewChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 597);
            this.Controls.Add(this.labelAirTypeInfo);
            this.Controls.Add(this.labelAircraftType);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.labelDcheckInfo);
            this.Controls.Add(this.labelCcheckInfo);
            this.Controls.Add(this.labelBcheckInfo);
            this.Controls.Add(this.labelAcheckInfo);
            this.Controls.Add(this.labelDcheck);
            this.Controls.Add(this.labelCcheck);
            this.Controls.Add(this.labelBcheck);
            this.Controls.Add(this.labelAcheck);
            this.Controls.Add(this.comboBoxAircraft);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.labelLocation);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 635);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 635);
            this.Name = "ReviewChecks";
            this.Text = "reviewChecks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.ComboBox comboBoxAircraft;
        private System.Windows.Forms.Label labelAcheck;
        private System.Windows.Forms.Label labelBcheck;
        private System.Windows.Forms.Label labelCcheck;
        private System.Windows.Forms.Label labelDcheck;
        private System.Windows.Forms.Label labelAcheckInfo;
        private System.Windows.Forms.Label labelBcheckInfo;
        private System.Windows.Forms.Label labelCcheckInfo;
        private System.Windows.Forms.Label labelDcheckInfo;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelAircraftType;
        private System.Windows.Forms.Label labelAirTypeInfo;
    }
}