namespace WindowsFormsApp2
{
    partial class AirlineOperatorUI
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
            this.resetInfoBtn = new System.Windows.Forms.Button();
            this.updateProfileBtn = new System.Windows.Forms.Button();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.dbaNameTextBox = new System.Windows.Forms.TextBox();
            this.dbaNameLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.companyAddressLabel = new System.Windows.Forms.Label();
            this.mcNoTextBox = new System.Windows.Forms.TextBox();
            this.mcLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.legalNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.ticketGroupBox = new System.Windows.Forms.GroupBox();
            this.addFlightBtn = new System.Windows.Forms.Button();
            this.updateExistingFlightBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.historyLabel = new System.Windows.Forms.Label();
            this.deleteAccountBtn = new System.Windows.Forms.Button();
            this.deleteFlightBtn = new System.Windows.Forms.Button();
            this.personalInfoGroupBox.SuspendLayout();
            this.ticketGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // resetInfoBtn
            // 
            this.resetInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetInfoBtn.Location = new System.Drawing.Point(1040, 461);
            this.resetInfoBtn.Name = "resetInfoBtn";
            this.resetInfoBtn.Size = new System.Drawing.Size(165, 41);
            this.resetInfoBtn.TabIndex = 25;
            this.resetInfoBtn.Text = "Reset Info";
            this.resetInfoBtn.UseVisualStyleBackColor = true;
            this.resetInfoBtn.Click += new System.EventHandler(this.resetInfoBtn_Click);
            // 
            // updateProfileBtn
            // 
            this.updateProfileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateProfileBtn.Location = new System.Drawing.Point(869, 461);
            this.updateProfileBtn.Name = "updateProfileBtn";
            this.updateProfileBtn.Size = new System.Drawing.Size(165, 41);
            this.updateProfileBtn.TabIndex = 24;
            this.updateProfileBtn.Text = "Update Profile";
            this.updateProfileBtn.UseVisualStyleBackColor = true;
            this.updateProfileBtn.Click += new System.EventHandler(this.updateProfileBtn_Click);
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personalInfoGroupBox.Controls.Add(this.showPasswordCheckBox);
            this.personalInfoGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.personalInfoGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.personalInfoGroupBox.Controls.Add(this.passwordTextBox);
            this.personalInfoGroupBox.Controls.Add(this.passwordLabel);
            this.personalInfoGroupBox.Controls.Add(this.usernameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.usernameLabel);
            this.personalInfoGroupBox.Controls.Add(this.dbaNameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.dbaNameLabel);
            this.personalInfoGroupBox.Controls.Add(this.countryTextBox);
            this.personalInfoGroupBox.Controls.Add(this.cityTextBox);
            this.personalInfoGroupBox.Controls.Add(this.streetTextBox);
            this.personalInfoGroupBox.Controls.Add(this.countryLabel);
            this.personalInfoGroupBox.Controls.Add(this.cityLabel);
            this.personalInfoGroupBox.Controls.Add(this.streetLabel);
            this.personalInfoGroupBox.Controls.Add(this.companyAddressLabel);
            this.personalInfoGroupBox.Controls.Add(this.mcNoTextBox);
            this.personalInfoGroupBox.Controls.Add(this.mcLabel);
            this.personalInfoGroupBox.Controls.Add(this.phoneTextBox);
            this.personalInfoGroupBox.Controls.Add(this.phoneLabel);
            this.personalInfoGroupBox.Controls.Add(this.legalNameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.nameLabel);
            this.personalInfoGroupBox.Location = new System.Drawing.Point(869, 72);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Size = new System.Drawing.Size(336, 383);
            this.personalInfoGroupBox.TabIndex = 23;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Airline Company Information";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(97, 341);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.showPasswordCheckBox.TabIndex = 107;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(97, 314);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(231, 20);
            this.confirmPasswordTextBox.TabIndex = 106;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(0, 317);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPasswordLabel.TabIndex = 105;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(97, 288);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(231, 20);
            this.passwordTextBox.TabIndex = 104;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(38, 291);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 103;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(78, 262);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(250, 20);
            this.usernameTextBox.TabIndex = 102;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(17, 265);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 101;
            this.usernameLabel.Text = "Username";
            // 
            // dbaNameTextBox
            // 
            this.dbaNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbaNameTextBox.Location = new System.Drawing.Point(68, 49);
            this.dbaNameTextBox.Name = "dbaNameTextBox";
            this.dbaNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.dbaNameTextBox.TabIndex = 62;
            // 
            // dbaNameLabel
            // 
            this.dbaNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbaNameLabel.AutoSize = true;
            this.dbaNameLabel.Location = new System.Drawing.Point(10, 52);
            this.dbaNameLabel.Name = "dbaNameLabel";
            this.dbaNameLabel.Size = new System.Drawing.Size(60, 13);
            this.dbaNameLabel.TabIndex = 61;
            this.dbaNameLabel.Text = "DBA Name";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryTextBox.Location = new System.Drawing.Point(150, 206);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(171, 20);
            this.countryTextBox.TabIndex = 60;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityTextBox.Location = new System.Drawing.Point(150, 182);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(171, 20);
            this.cityTextBox.TabIndex = 59;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.streetTextBox.Location = new System.Drawing.Point(150, 159);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(171, 20);
            this.streetTextBox.TabIndex = 58;
            // 
            // countryLabel
            // 
            this.countryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(101, 209);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 57;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(40, 185);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(101, 13);
            this.cityLabel.TabIndex = 56;
            this.cityLabel.Text = "City, State Zip Code";
            // 
            // streetLabel
            // 
            this.streetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(17, 162);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(127, 13);
            this.streetLabel.TabIndex = 55;
            this.streetLabel.Text = "Street Number and Name";
            // 
            // companyAddressLabel
            // 
            this.companyAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.companyAddressLabel.AutoSize = true;
            this.companyAddressLabel.Location = new System.Drawing.Point(16, 136);
            this.companyAddressLabel.Name = "companyAddressLabel";
            this.companyAddressLabel.Size = new System.Drawing.Size(92, 13);
            this.companyAddressLabel.TabIndex = 54;
            this.companyAddressLabel.Text = "Company Address";
            // 
            // mcNoTextBox
            // 
            this.mcNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcNoTextBox.Location = new System.Drawing.Point(61, 102);
            this.mcNoTextBox.Name = "mcNoTextBox";
            this.mcNoTextBox.ReadOnly = true;
            this.mcNoTextBox.Size = new System.Drawing.Size(260, 20);
            this.mcNoTextBox.TabIndex = 53;
            // 
            // mcLabel
            // 
            this.mcLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcLabel.AutoSize = true;
            this.mcLabel.Location = new System.Drawing.Point(23, 105);
            this.mcLabel.Name = "mcLabel";
            this.mcLabel.Size = new System.Drawing.Size(30, 13);
            this.mcLabel.TabIndex = 52;
            this.mcLabel.Text = "MC#";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.Location = new System.Drawing.Point(61, 76);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(260, 20);
            this.phoneTextBox.TabIndex = 51;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(17, 79);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 50;
            this.phoneLabel.Text = "Phone";
            // 
            // legalNameTextBox
            // 
            this.legalNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legalNameTextBox.Location = new System.Drawing.Point(68, 23);
            this.legalNameTextBox.Name = "legalNameTextBox";
            this.legalNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.legalNameTextBox.TabIndex = 49;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 13);
            this.nameLabel.TabIndex = 48;
            this.nameLabel.Text = "Legal Name";
            // 
            // profileLabel
            // 
            this.profileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(875, 37);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(36, 13);
            this.profileLabel.TabIndex = 22;
            this.profileLabel.Text = "Profile";
            // 
            // ticketGroupBox
            // 
            this.ticketGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketGroupBox.Controls.Add(this.deleteFlightBtn);
            this.ticketGroupBox.Controls.Add(this.addFlightBtn);
            this.ticketGroupBox.Controls.Add(this.updateExistingFlightBtn);
            this.ticketGroupBox.Location = new System.Drawing.Point(869, 555);
            this.ticketGroupBox.Name = "ticketGroupBox";
            this.ticketGroupBox.Size = new System.Drawing.Size(336, 53);
            this.ticketGroupBox.TabIndex = 21;
            this.ticketGroupBox.TabStop = false;
            this.ticketGroupBox.Text = "Regarding Ticket";
            // 
            // addFlightBtn
            // 
            this.addFlightBtn.Location = new System.Drawing.Point(6, 19);
            this.addFlightBtn.Name = "addFlightBtn";
            this.addFlightBtn.Size = new System.Drawing.Size(102, 23);
            this.addFlightBtn.TabIndex = 1;
            this.addFlightBtn.Text = "Add Flight";
            this.addFlightBtn.UseVisualStyleBackColor = true;
            this.addFlightBtn.Click += new System.EventHandler(this.addFlightBtn_Click);
            // 
            // updateExistingFlightBtn
            // 
            this.updateExistingFlightBtn.Location = new System.Drawing.Point(231, 19);
            this.updateExistingFlightBtn.Name = "updateExistingFlightBtn";
            this.updateExistingFlightBtn.Size = new System.Drawing.Size(97, 23);
            this.updateExistingFlightBtn.TabIndex = 3;
            this.updateExistingFlightBtn.Text = "Update Existing Flight";
            this.updateExistingFlightBtn.UseVisualStyleBackColor = true;
            this.updateExistingFlightBtn.Click += new System.EventHandler(this.updateExistingFlightBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.Location = new System.Drawing.Point(1065, 15);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(140, 23);
            this.logOutBtn.TabIndex = 20;
            this.logOutBtn.Text = "Log Out as Flight Operator";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 576);
            this.dataGridView1.TabIndex = 19;
            // 
            // historyLabel
            // 
            this.historyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(12, 15);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(130, 13);
            this.historyLabel.TabIndex = 18;
            this.historyLabel.Text = "History of Available Flights";
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccountBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteAccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteAccountBtn.Location = new System.Drawing.Point(869, 508);
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.Size = new System.Drawing.Size(336, 41);
            this.deleteAccountBtn.TabIndex = 26;
            this.deleteAccountBtn.Text = "Delete Account";
            this.deleteAccountBtn.UseVisualStyleBackColor = false;
            this.deleteAccountBtn.Click += new System.EventHandler(this.deleteAccountBtn_Click);
            // 
            // deleteFlightBtn
            // 
            this.deleteFlightBtn.Location = new System.Drawing.Point(114, 19);
            this.deleteFlightBtn.Name = "deleteFlightBtn";
            this.deleteFlightBtn.Size = new System.Drawing.Size(111, 23);
            this.deleteFlightBtn.TabIndex = 4;
            this.deleteFlightBtn.Text = "Delete Flight";
            this.deleteFlightBtn.UseVisualStyleBackColor = true;
            this.deleteFlightBtn.Click += new System.EventHandler(this.deleteFlightBtn_Click);
            // 
            // AirlineOperatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 645);
            this.ControlBox = false;
            this.Controls.Add(this.deleteAccountBtn);
            this.Controls.Add(this.resetInfoBtn);
            this.Controls.Add(this.updateProfileBtn);
            this.Controls.Add(this.personalInfoGroupBox);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.ticketGroupBox);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.historyLabel);
            this.MinimumSize = new System.Drawing.Size(1233, 661);
            this.Name = "AirlineOperatorUI";
            this.Text = "AirlineOperatorUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AirlineOperatorUI_Load);
            this.Shown += new System.EventHandler(this.AirlineOperatorUI_Shown);
            this.personalInfoGroupBox.ResumeLayout(false);
            this.personalInfoGroupBox.PerformLayout();
            this.ticketGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resetInfoBtn;
        private System.Windows.Forms.Button updateProfileBtn;
        private System.Windows.Forms.GroupBox personalInfoGroupBox;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.GroupBox ticketGroupBox;
        private System.Windows.Forms.Button addFlightBtn;
        private System.Windows.Forms.Button updateExistingFlightBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.TextBox dbaNameTextBox;
        private System.Windows.Forms.Label dbaNameLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label companyAddressLabel;
        private System.Windows.Forms.TextBox mcNoTextBox;
        private System.Windows.Forms.Label mcLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox legalNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Button deleteAccountBtn;
        private System.Windows.Forms.Button deleteFlightBtn;
    }
}