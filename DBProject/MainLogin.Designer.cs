namespace WindowsFormsApp2
{
    partial class MainLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.signupPassengerLabel = new System.Windows.Forms.Label();
            this.signupAirlineOperatorLabel = new System.Windows.Forms.Label();
            this.loginAsComboBox = new System.Windows.Forms.ComboBox();
            this.loginAsLabel = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Airline Reservation System";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(199, 188);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(260, 181);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(216, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(260, 207);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(216, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(201, 214);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(401, 257);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // signupPassengerLabel
            // 
            this.signupPassengerLabel.AutoSize = true;
            this.signupPassengerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.signupPassengerLabel.Location = new System.Drawing.Point(201, 356);
            this.signupPassengerLabel.Name = "signupPassengerLabel";
            this.signupPassengerLabel.Size = new System.Drawing.Size(172, 13);
            this.signupPassengerLabel.TabIndex = 6;
            this.signupPassengerLabel.Text = "Click here to Sign up as Passenger";
            this.signupPassengerLabel.Click += new System.EventHandler(this.signupPassengerLabel_Click);
            // 
            // signupAirlineOperatorLabel
            // 
            this.signupAirlineOperatorLabel.AutoSize = true;
            this.signupAirlineOperatorLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.signupAirlineOperatorLabel.Location = new System.Drawing.Point(201, 378);
            this.signupAirlineOperatorLabel.Name = "signupAirlineOperatorLabel";
            this.signupAirlineOperatorLabel.Size = new System.Drawing.Size(209, 13);
            this.signupAirlineOperatorLabel.TabIndex = 7;
            this.signupAirlineOperatorLabel.Text = "Click here to Sign up as an Airline Operator";
            this.signupAirlineOperatorLabel.Click += new System.EventHandler(this.signupAirlineOperatorLabel_Click);
            // 
            // loginAsComboBox
            // 
            this.loginAsComboBox.FormattingEnabled = true;
            this.loginAsComboBox.Items.AddRange(new object[] {
            "Passenger",
            "Airline Operator",
            "Administrator"});
            this.loginAsComboBox.Location = new System.Drawing.Point(204, 118);
            this.loginAsComboBox.Name = "loginAsComboBox";
            this.loginAsComboBox.Size = new System.Drawing.Size(160, 21);
            this.loginAsComboBox.TabIndex = 8;
            // 
            // loginAsLabel
            // 
            this.loginAsLabel.AutoSize = true;
            this.loginAsLabel.Location = new System.Drawing.Point(201, 102);
            this.loginAsLabel.Name = "loginAsLabel";
            this.loginAsLabel.Size = new System.Drawing.Size(47, 13);
            this.loginAsLabel.TabIndex = 9;
            this.loginAsLabel.Text = "Login as";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(260, 257);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.showPasswordCheckBox.TabIndex = 10;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 477);
            this.ControlBox = false;
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.loginAsLabel);
            this.Controls.Add(this.loginAsComboBox);
            this.Controls.Add(this.signupAirlineOperatorLabel);
            this.Controls.Add(this.signupPassengerLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(734, 493);
            this.Name = "MainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label signupPassengerLabel;
        private System.Windows.Forms.Label signupAirlineOperatorLabel;
        private System.Windows.Forms.ComboBox loginAsComboBox;
        private System.Windows.Forms.Label loginAsLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
    }
}