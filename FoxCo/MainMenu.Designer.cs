namespace FoxCo
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.buttonCustService = new System.Windows.Forms.Button();
            this.buttonMaintenance = new System.Windows.Forms.Button();
            this.buttonFinancial = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonLogOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.White;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(254, 71);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(332, 31);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Internal Colleague System";
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.labelLoggedIn.ForeColor = System.Drawing.Color.White;
            this.labelLoggedIn.Location = new System.Drawing.Point(617, 53);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(65, 13);
            this.labelLoggedIn.TabIndex = 1;
            this.labelLoggedIn.Text = "PlaceHolder";
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
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "label1";
            this.labelVersion.UseWaitCursor = true;
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
            this.labelCopyright.TabIndex = 8;
            this.labelCopyright.Text = "©Dundee and Angus College 2018";
            this.labelCopyright.UseWaitCursor = true;
            // 
            // buttonCustService
            // 
            this.buttonCustService.BackColor = System.Drawing.Color.Black;
            this.buttonCustService.Enabled = false;
            this.buttonCustService.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustService.ForeColor = System.Drawing.Color.White;
            this.buttonCustService.Location = new System.Drawing.Point(75, 156);
            this.buttonCustService.Name = "buttonCustService";
            this.buttonCustService.Size = new System.Drawing.Size(173, 72);
            this.buttonCustService.TabIndex = 9;
            this.buttonCustService.Text = "Customer Service";
            this.buttonCustService.UseVisualStyleBackColor = false;
            this.buttonCustService.Click += new System.EventHandler(this.buttonCustService_Click);
            // 
            // buttonMaintenance
            // 
            this.buttonMaintenance.BackColor = System.Drawing.Color.Black;
            this.buttonMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMaintenance.Enabled = false;
            this.buttonMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaintenance.ForeColor = System.Drawing.Color.White;
            this.buttonMaintenance.Location = new System.Drawing.Point(527, 156);
            this.buttonMaintenance.Name = "buttonMaintenance";
            this.buttonMaintenance.Size = new System.Drawing.Size(173, 72);
            this.buttonMaintenance.TabIndex = 10;
            this.buttonMaintenance.Text = "Maintenance";
            this.buttonMaintenance.UseVisualStyleBackColor = false;
            this.buttonMaintenance.Click += new System.EventHandler(this.buttonMaintenance_Click);
            // 
            // buttonFinancial
            // 
            this.buttonFinancial.BackColor = System.Drawing.Color.Gray;
            this.buttonFinancial.Enabled = false;
            this.buttonFinancial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinancial.ForeColor = System.Drawing.Color.White;
            this.buttonFinancial.Location = new System.Drawing.Point(75, 292);
            this.buttonFinancial.Name = "buttonFinancial";
            this.buttonFinancial.Size = new System.Drawing.Size(173, 72);
            this.buttonFinancial.TabIndex = 11;
            this.buttonFinancial.Text = "Financial (Not Functional)";
            this.buttonFinancial.UseVisualStyleBackColor = false;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.Gray;
            this.buttonCheckIn.Enabled = false;
            this.buttonCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.White;
            this.buttonCheckIn.Location = new System.Drawing.Point(527, 292);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(173, 72);
            this.buttonCheckIn.TabIndex = 12;
            this.buttonCheckIn.Text = "Check-In (Not Functional)";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Black;
            this.buttonAdmin.Enabled = false;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Location = new System.Drawing.Point(75, 431);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(173, 72);
            this.buttonAdmin.TabIndex = 13;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonLogOff
            // 
            this.buttonLogOff.BackColor = System.Drawing.Color.Black;
            this.buttonLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOff.ForeColor = System.Drawing.Color.White;
            this.buttonLogOff.Location = new System.Drawing.Point(527, 431);
            this.buttonLogOff.Name = "buttonLogOff";
            this.buttonLogOff.Size = new System.Drawing.Size(173, 72);
            this.buttonLogOff.TabIndex = 14;
            this.buttonLogOff.Text = "Log Off";
            this.buttonLogOff.UseVisualStyleBackColor = false;
            this.buttonLogOff.Click += new System.EventHandler(this.buttonLogOff_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.Controls.Add(this.buttonLogOff);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.buttonFinancial);
            this.Controls.Add(this.buttonMaintenance);
            this.Controls.Add(this.buttonCustService);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.labelLocation);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 635);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 635);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button buttonCustService;
        private System.Windows.Forms.Button buttonMaintenance;
        private System.Windows.Forms.Button buttonFinancial;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonLogOff;
    }
}