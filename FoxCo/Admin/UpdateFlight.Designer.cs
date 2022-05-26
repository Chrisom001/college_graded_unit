namespace FoxCo.Admin
{
    partial class UpdateFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFlight));
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelFlight = new System.Windows.Forms.Label();
            this.comboBoxFlights = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSelectFlight = new System.Windows.Forms.Button();
            this.comboBoxAircraft = new System.Windows.Forms.ComboBox();
            this.comboBoxRoutes = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAircraftPick = new System.Windows.Forms.Label();
            this.labelRoutePick = new System.Windows.Forms.Label();
            this.labelDatePick = new System.Windows.Forms.Label();
            this.labelNewDet = new System.Windows.Forms.Label();
            this.labelOrig = new System.Windows.Forms.Label();
            this.labelOrigAircraft = new System.Windows.Forms.Label();
            this.labelOrigRoute = new System.Windows.Forms.Label();
            this.labelOrigDate = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
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
            this.labelCopyright.TabIndex = 22;
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
            this.labelVersion.TabIndex = 21;
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
            this.labelLoggedIn.TabIndex = 13;
            this.labelLoggedIn.Text = "PlaceHolder";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.White;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(318, 72);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(176, 31);
            this.labelLocation.TabIndex = 12;
            this.labelLocation.Text = "Update Flight";
            // 
            // labelFlight
            // 
            this.labelFlight.AutoSize = true;
            this.labelFlight.BackColor = System.Drawing.Color.White;
            this.labelFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlight.Location = new System.Drawing.Point(192, 182);
            this.labelFlight.Name = "labelFlight";
            this.labelFlight.Size = new System.Drawing.Size(55, 18);
            this.labelFlight.TabIndex = 27;
            this.labelFlight.Text = "Flights:";
            // 
            // comboBoxFlights
            // 
            this.comboBoxFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFlights.FormattingEnabled = true;
            this.comboBoxFlights.Location = new System.Drawing.Point(265, 174);
            this.comboBoxFlights.Name = "comboBoxFlights";
            this.comboBoxFlights.Size = new System.Drawing.Size(229, 26);
            this.comboBoxFlights.TabIndex = 26;
            this.comboBoxFlights.Text = "Please select a Flight to update";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Please select the flight you wish to update then enter the updated details";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Black;
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(492, 462);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(140, 50);
            this.buttonReturn.TabIndex = 29;
            this.buttonReturn.Text = "Return to Previous Page";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSelectFlight
            // 
            this.buttonSelectFlight.BackColor = System.Drawing.Color.Black;
            this.buttonSelectFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectFlight.ForeColor = System.Drawing.Color.White;
            this.buttonSelectFlight.Location = new System.Drawing.Point(354, 220);
            this.buttonSelectFlight.Name = "buttonSelectFlight";
            this.buttonSelectFlight.Size = new System.Drawing.Size(140, 30);
            this.buttonSelectFlight.TabIndex = 30;
            this.buttonSelectFlight.Text = "Select Flight";
            this.buttonSelectFlight.UseVisualStyleBackColor = false;
            this.buttonSelectFlight.Click += new System.EventHandler(this.buttonSelectFlight_Click);
            // 
            // comboBoxAircraft
            // 
            this.comboBoxAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxAircraft.FormattingEnabled = true;
            this.comboBoxAircraft.Location = new System.Drawing.Point(165, 314);
            this.comboBoxAircraft.Name = "comboBoxAircraft";
            this.comboBoxAircraft.Size = new System.Drawing.Size(200, 26);
            this.comboBoxAircraft.TabIndex = 31;
            this.comboBoxAircraft.Text = "Please select an Aircraft";
            this.comboBoxAircraft.Visible = false;
            // 
            // comboBoxRoutes
            // 
            this.comboBoxRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxRoutes.FormattingEnabled = true;
            this.comboBoxRoutes.Location = new System.Drawing.Point(165, 360);
            this.comboBoxRoutes.Name = "comboBoxRoutes";
            this.comboBoxRoutes.Size = new System.Drawing.Size(200, 26);
            this.comboBoxRoutes.TabIndex = 32;
            this.comboBoxRoutes.Text = "Please select a Route";
            this.comboBoxRoutes.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 402);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.Value = new System.DateTime(2018, 3, 13, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // labelAircraftPick
            // 
            this.labelAircraftPick.AutoSize = true;
            this.labelAircraftPick.BackColor = System.Drawing.Color.White;
            this.labelAircraftPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelAircraftPick.Location = new System.Drawing.Point(101, 322);
            this.labelAircraftPick.Name = "labelAircraftPick";
            this.labelAircraftPick.Size = new System.Drawing.Size(58, 18);
            this.labelAircraftPick.TabIndex = 34;
            this.labelAircraftPick.Text = "Aircraft:";
            this.labelAircraftPick.Visible = false;
            // 
            // labelRoutePick
            // 
            this.labelRoutePick.AutoSize = true;
            this.labelRoutePick.BackColor = System.Drawing.Color.White;
            this.labelRoutePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelRoutePick.Location = new System.Drawing.Point(101, 368);
            this.labelRoutePick.Name = "labelRoutePick";
            this.labelRoutePick.Size = new System.Drawing.Size(52, 18);
            this.labelRoutePick.TabIndex = 35;
            this.labelRoutePick.Text = "Route:";
            this.labelRoutePick.Visible = false;
            // 
            // labelDatePick
            // 
            this.labelDatePick.AutoSize = true;
            this.labelDatePick.BackColor = System.Drawing.Color.White;
            this.labelDatePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelDatePick.Location = new System.Drawing.Point(101, 407);
            this.labelDatePick.Name = "labelDatePick";
            this.labelDatePick.Size = new System.Drawing.Size(43, 18);
            this.labelDatePick.TabIndex = 36;
            this.labelDatePick.Text = "Date:";
            this.labelDatePick.Visible = false;
            // 
            // labelNewDet
            // 
            this.labelNewDet.AutoSize = true;
            this.labelNewDet.BackColor = System.Drawing.Color.White;
            this.labelNewDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelNewDet.Location = new System.Drawing.Point(192, 278);
            this.labelNewDet.Name = "labelNewDet";
            this.labelNewDet.Size = new System.Drawing.Size(116, 18);
            this.labelNewDet.TabIndex = 37;
            this.labelNewDet.Text = "Changed Details";
            this.labelNewDet.Visible = false;
            // 
            // labelOrig
            // 
            this.labelOrig.AutoSize = true;
            this.labelOrig.BackColor = System.Drawing.Color.White;
            this.labelOrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelOrig.Location = new System.Drawing.Point(525, 278);
            this.labelOrig.Name = "labelOrig";
            this.labelOrig.Size = new System.Drawing.Size(107, 18);
            this.labelOrig.TabIndex = 38;
            this.labelOrig.Text = "Original Details";
            this.labelOrig.Visible = false;
            // 
            // labelOrigAircraft
            // 
            this.labelOrigAircraft.AutoSize = true;
            this.labelOrigAircraft.BackColor = System.Drawing.Color.White;
            this.labelOrigAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelOrigAircraft.Location = new System.Drawing.Point(515, 314);
            this.labelOrigAircraft.Name = "labelOrigAircraft";
            this.labelOrigAircraft.Size = new System.Drawing.Size(86, 18);
            this.labelOrigAircraft.TabIndex = 39;
            this.labelOrigAircraft.Text = "Placeholder";
            this.labelOrigAircraft.Visible = false;
            // 
            // labelOrigRoute
            // 
            this.labelOrigRoute.AutoSize = true;
            this.labelOrigRoute.BackColor = System.Drawing.Color.White;
            this.labelOrigRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelOrigRoute.Location = new System.Drawing.Point(515, 363);
            this.labelOrigRoute.Name = "labelOrigRoute";
            this.labelOrigRoute.Size = new System.Drawing.Size(86, 18);
            this.labelOrigRoute.TabIndex = 40;
            this.labelOrigRoute.Text = "Placeholder";
            this.labelOrigRoute.Visible = false;
            // 
            // labelOrigDate
            // 
            this.labelOrigDate.AutoSize = true;
            this.labelOrigDate.BackColor = System.Drawing.Color.White;
            this.labelOrigDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelOrigDate.Location = new System.Drawing.Point(515, 408);
            this.labelOrigDate.Name = "labelOrigDate";
            this.labelOrigDate.Size = new System.Drawing.Size(86, 18);
            this.labelOrigDate.TabIndex = 41;
            this.labelOrigDate.Text = "Placeholder";
            this.labelOrigDate.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Black;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(165, 461);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 50);
            this.buttonUpdate.TabIndex = 42;
            this.buttonUpdate.Text = "Update Flight";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UpdateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 597);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelOrigDate);
            this.Controls.Add(this.labelOrigRoute);
            this.Controls.Add(this.labelOrigAircraft);
            this.Controls.Add(this.labelOrig);
            this.Controls.Add(this.labelNewDet);
            this.Controls.Add(this.labelDatePick);
            this.Controls.Add(this.labelRoutePick);
            this.Controls.Add(this.labelAircraftPick);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxRoutes);
            this.Controls.Add(this.comboBoxAircraft);
            this.Controls.Add(this.buttonSelectFlight);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFlight);
            this.Controls.Add(this.comboBoxFlights);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.labelLocation);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 635);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 635);
            this.Name = "UpdateFlight";
            this.Text = "UpdateFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelFlight;
        private System.Windows.Forms.ComboBox comboBoxFlights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonSelectFlight;
        private System.Windows.Forms.ComboBox comboBoxAircraft;
        private System.Windows.Forms.ComboBox comboBoxRoutes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelAircraftPick;
        private System.Windows.Forms.Label labelRoutePick;
        private System.Windows.Forms.Label labelDatePick;
        private System.Windows.Forms.Label labelNewDet;
        private System.Windows.Forms.Label labelOrig;
        private System.Windows.Forms.Label labelOrigAircraft;
        private System.Windows.Forms.Label labelOrigRoute;
        private System.Windows.Forms.Label labelOrigDate;
        private System.Windows.Forms.Button buttonUpdate;
    }
}