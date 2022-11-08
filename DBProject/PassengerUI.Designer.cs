namespace WindowsFormsApp2
{
    partial class PassengerUI
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
            this.historyLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resetInfoBtn = new System.Windows.Forms.Button();
            this.updateProfileBtn = new System.Windows.Forms.Button();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cnicTextBox = new System.Windows.Forms.TextBox();
            this.cnicLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.ticketGroupBox = new System.Windows.Forms.GroupBox();
            this.bookTicketBtn = new System.Windows.Forms.Button();
            this.refreshTicketBtn = new System.Windows.Forms.Button();
            this.cancelTicketBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.deleteAccountBtn = new System.Windows.Forms.Button();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.personalInfoGroupBox.SuspendLayout();
            this.ticketGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyLabel
            // 
            this.historyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(12, 17);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(129, 13);
            this.historyLabel.TabIndex = 5;
            this.historyLabel.Text = "History of Booked Tickets";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 576);
            this.dataGridView1.TabIndex = 6;
            // 
            // resetInfoBtn
            // 
            this.resetInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetInfoBtn.Location = new System.Drawing.Point(1040, 463);
            this.resetInfoBtn.Name = "resetInfoBtn";
            this.resetInfoBtn.Size = new System.Drawing.Size(165, 41);
            this.resetInfoBtn.TabIndex = 16;
            this.resetInfoBtn.Text = "Reset Info";
            this.resetInfoBtn.UseVisualStyleBackColor = true;
            this.resetInfoBtn.Click += new System.EventHandler(this.resetInfoBtn_Click);
            // 
            // updateProfileBtn
            // 
            this.updateProfileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateProfileBtn.Location = new System.Drawing.Point(869, 463);
            this.updateProfileBtn.Name = "updateProfileBtn";
            this.updateProfileBtn.Size = new System.Drawing.Size(165, 41);
            this.updateProfileBtn.TabIndex = 15;
            this.updateProfileBtn.Text = "Update Profile";
            this.updateProfileBtn.UseVisualStyleBackColor = true;
            this.updateProfileBtn.Click += new System.EventHandler(this.updateProfileBtn_Click);
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personalInfoGroupBox.Controls.Add(this.showPasswordCheckBox);
            this.personalInfoGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.personalInfoGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.personalInfoGroupBox.Controls.Add(this.passwordTextBox);
            this.personalInfoGroupBox.Controls.Add(this.passwordLabel);
            this.personalInfoGroupBox.Controls.Add(this.usernameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.usernameLabel);
            this.personalInfoGroupBox.Controls.Add(this.countryTextBox);
            this.personalInfoGroupBox.Controls.Add(this.cityTextBox);
            this.personalInfoGroupBox.Controls.Add(this.streetTextBox);
            this.personalInfoGroupBox.Controls.Add(this.countryLabel);
            this.personalInfoGroupBox.Controls.Add(this.cityLabel);
            this.personalInfoGroupBox.Controls.Add(this.streetLabel);
            this.personalInfoGroupBox.Controls.Add(this.addressLabel);
            this.personalInfoGroupBox.Controls.Add(this.cnicTextBox);
            this.personalInfoGroupBox.Controls.Add(this.cnicLabel);
            this.personalInfoGroupBox.Controls.Add(this.phoneTextBox);
            this.personalInfoGroupBox.Controls.Add(this.nameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.phoneLabel);
            this.personalInfoGroupBox.Controls.Add(this.nameLabel);
            this.personalInfoGroupBox.Location = new System.Drawing.Point(869, 74);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Size = new System.Drawing.Size(336, 383);
            this.personalInfoGroupBox.TabIndex = 14;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Personal Information";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(103, 308);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(225, 20);
            this.confirmPasswordTextBox.TabIndex = 112;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(6, 311);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPasswordLabel.TabIndex = 111;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(103, 282);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(225, 20);
            this.passwordTextBox.TabIndex = 110;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(44, 285);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 109;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(84, 256);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(244, 20);
            this.usernameTextBox.TabIndex = 108;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(23, 259);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 107;
            this.usernameLabel.Text = "Username";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryTextBox.Location = new System.Drawing.Point(146, 204);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(182, 20);
            this.countryTextBox.TabIndex = 27;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.Location = new System.Drawing.Point(145, 180);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(183, 20);
            this.cityTextBox.TabIndex = 26;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streetTextBox.Location = new System.Drawing.Point(145, 157);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(183, 20);
            this.streetTextBox.TabIndex = 25;
            // 
            // countryLabel
            // 
            this.countryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(100, 207);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 24;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(45, 183);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(101, 13);
            this.cityLabel.TabIndex = 23;
            this.cityLabel.Text = "City, State Zip Code";
            // 
            // streetLabel
            // 
            this.streetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(19, 160);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(127, 13);
            this.streetLabel.TabIndex = 22;
            this.streetLabel.Text = "Street Number and Name";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(19, 133);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 21;
            this.addressLabel.Text = "Address";
            // 
            // cnicTextBox
            // 
            this.cnicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cnicTextBox.Location = new System.Drawing.Point(57, 87);
            this.cnicTextBox.Name = "cnicTextBox";
            this.cnicTextBox.Size = new System.Drawing.Size(271, 20);
            this.cnicTextBox.TabIndex = 20;
            // 
            // cnicLabel
            // 
            this.cnicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cnicLabel.AutoSize = true;
            this.cnicLabel.Location = new System.Drawing.Point(19, 90);
            this.cnicLabel.Name = "cnicLabel";
            this.cnicLabel.Size = new System.Drawing.Size(32, 13);
            this.cnicLabel.TabIndex = 19;
            this.cnicLabel.Text = "CNIC";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Location = new System.Drawing.Point(57, 52);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(271, 20);
            this.phoneTextBox.TabIndex = 18;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(57, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(271, 20);
            this.nameTextBox.TabIndex = 17;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(19, 55);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 16;
            this.phoneLabel.Text = "Phone";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // profileLabel
            // 
            this.profileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(875, 39);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(36, 13);
            this.profileLabel.TabIndex = 13;
            this.profileLabel.Text = "Profile";
            // 
            // ticketGroupBox
            // 
            this.ticketGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketGroupBox.Controls.Add(this.bookTicketBtn);
            this.ticketGroupBox.Controls.Add(this.refreshTicketBtn);
            this.ticketGroupBox.Controls.Add(this.cancelTicketBtn);
            this.ticketGroupBox.Location = new System.Drawing.Point(869, 557);
            this.ticketGroupBox.Name = "ticketGroupBox";
            this.ticketGroupBox.Size = new System.Drawing.Size(336, 53);
            this.ticketGroupBox.TabIndex = 12;
            this.ticketGroupBox.TabStop = false;
            this.ticketGroupBox.Text = "Regarding Ticket";
            // 
            // bookTicketBtn
            // 
            this.bookTicketBtn.Location = new System.Drawing.Point(6, 19);
            this.bookTicketBtn.Name = "bookTicketBtn";
            this.bookTicketBtn.Size = new System.Drawing.Size(75, 23);
            this.bookTicketBtn.TabIndex = 1;
            this.bookTicketBtn.Text = "Book Ticket";
            this.bookTicketBtn.UseVisualStyleBackColor = true;
            this.bookTicketBtn.Click += new System.EventHandler(this.bookTicketBtn_Click);
            // 
            // refreshTicketBtn
            // 
            this.refreshTicketBtn.Location = new System.Drawing.Point(196, 19);
            this.refreshTicketBtn.Name = "refreshTicketBtn";
            this.refreshTicketBtn.Size = new System.Drawing.Size(132, 23);
            this.refreshTicketBtn.TabIndex = 3;
            this.refreshTicketBtn.Text = "Refresh Booked Tickets";
            this.refreshTicketBtn.UseVisualStyleBackColor = true;
            this.refreshTicketBtn.Click += new System.EventHandler(this.refreshTicketBtn_Click);
            // 
            // cancelTicketBtn
            // 
            this.cancelTicketBtn.Location = new System.Drawing.Point(87, 19);
            this.cancelTicketBtn.Name = "cancelTicketBtn";
            this.cancelTicketBtn.Size = new System.Drawing.Size(103, 23);
            this.cancelTicketBtn.TabIndex = 2;
            this.cancelTicketBtn.Text = "Cancel Ticket";
            this.cancelTicketBtn.UseVisualStyleBackColor = true;
            this.cancelTicketBtn.Click += new System.EventHandler(this.cancelTicketBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.Location = new System.Drawing.Point(1065, 17);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(140, 23);
            this.logOutBtn.TabIndex = 11;
            this.logOutBtn.Text = "Log Out as Passenger";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccountBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteAccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteAccountBtn.Location = new System.Drawing.Point(869, 510);
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.Size = new System.Drawing.Size(336, 41);
            this.deleteAccountBtn.TabIndex = 17;
            this.deleteAccountBtn.Text = "Delete Account";
            this.deleteAccountBtn.UseVisualStyleBackColor = false;
            this.deleteAccountBtn.Click += new System.EventHandler(this.deleteAccountBtn_Click);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(103, 335);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.showPasswordCheckBox.TabIndex = 113;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // PassengerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 622);
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
            this.MinimumSize = new System.Drawing.Size(971, 482);
            this.Name = "PassengerUI";
            this.Text = "Passenger Interface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PassengerUI_Load);
            this.Shown += new System.EventHandler(this.PassengerUI_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.personalInfoGroupBox.ResumeLayout(false);
            this.personalInfoGroupBox.PerformLayout();
            this.ticketGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button resetInfoBtn;
        private System.Windows.Forms.Button updateProfileBtn;
        private System.Windows.Forms.GroupBox personalInfoGroupBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox cnicTextBox;
        private System.Windows.Forms.Label cnicLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.GroupBox ticketGroupBox;
        private System.Windows.Forms.Button bookTicketBtn;
        private System.Windows.Forms.Button refreshTicketBtn;
        private System.Windows.Forms.Button cancelTicketBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button deleteAccountBtn;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
    }
}