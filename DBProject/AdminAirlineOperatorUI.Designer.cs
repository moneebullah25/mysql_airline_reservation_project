using System;

namespace WindowsFormsApp2
{
    partial class AdminAirlineOperatorUI
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
            this.deleteAirlineBtn = new System.Windows.Forms.Button();
            this.updateAirlineBtn = new System.Windows.Forms.Button();
            this.addAirlineBtn = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quitBtn = new System.Windows.Forms.Button();
            this.clearAirlineBtn = new System.Windows.Forms.Button();
            this.dbaNameTextBox = new System.Windows.Forms.TextBox();
            this.dbaNameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteAirlineBtn
            // 
            this.deleteAirlineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAirlineBtn.Location = new System.Drawing.Point(1092, 555);
            this.deleteAirlineBtn.Name = "deleteAirlineBtn";
            this.deleteAirlineBtn.Size = new System.Drawing.Size(109, 23);
            this.deleteAirlineBtn.TabIndex = 45;
            this.deleteAirlineBtn.Text = "Delete Airline";
            this.deleteAirlineBtn.UseVisualStyleBackColor = true;
            this.deleteAirlineBtn.Click += new System.EventHandler(this.deleteAirlineBtn_Click);
            // 
            // updateAirlineBtn
            // 
            this.updateAirlineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateAirlineBtn.Location = new System.Drawing.Point(977, 555);
            this.updateAirlineBtn.Name = "updateAirlineBtn";
            this.updateAirlineBtn.Size = new System.Drawing.Size(109, 23);
            this.updateAirlineBtn.TabIndex = 44;
            this.updateAirlineBtn.Text = "Update Airline";
            this.updateAirlineBtn.UseVisualStyleBackColor = true;
            this.updateAirlineBtn.Click += new System.EventHandler(this.updateAirlineBtn_Click);
            // 
            // addAirlineBtn
            // 
            this.addAirlineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAirlineBtn.Location = new System.Drawing.Point(865, 555);
            this.addAirlineBtn.Name = "addAirlineBtn";
            this.addAirlineBtn.Size = new System.Drawing.Size(106, 23);
            this.addAirlineBtn.TabIndex = 43;
            this.addAirlineBtn.Text = "Add Airline";
            this.addAirlineBtn.UseVisualStyleBackColor = true;
            this.addAirlineBtn.Click += new System.EventHandler(this.addAirlineBtn_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countryTextBox.Location = new System.Drawing.Point(1009, 195);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(171, 20);
            this.countryTextBox.TabIndex = 41;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.Location = new System.Drawing.Point(1009, 171);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(171, 20);
            this.cityTextBox.TabIndex = 40;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.streetTextBox.Location = new System.Drawing.Point(1009, 148);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(171, 20);
            this.streetTextBox.TabIndex = 39;
            // 
            // countryLabel
            // 
            this.countryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(960, 198);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 38;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(899, 174);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(101, 13);
            this.cityLabel.TabIndex = 37;
            this.cityLabel.Text = "City, State Zip Code";
            // 
            // streetLabel
            // 
            this.streetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(876, 151);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(127, 13);
            this.streetLabel.TabIndex = 36;
            this.streetLabel.Text = "Street Number and Name";
            // 
            // companyAddressLabel
            // 
            this.companyAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyAddressLabel.AutoSize = true;
            this.companyAddressLabel.Location = new System.Drawing.Point(875, 125);
            this.companyAddressLabel.Name = "companyAddressLabel";
            this.companyAddressLabel.Size = new System.Drawing.Size(92, 13);
            this.companyAddressLabel.TabIndex = 35;
            this.companyAddressLabel.Text = "Company Address";
            // 
            // mcNoTextBox
            // 
            this.mcNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mcNoTextBox.Location = new System.Drawing.Point(920, 91);
            this.mcNoTextBox.Name = "mcNoTextBox";
            this.mcNoTextBox.Size = new System.Drawing.Size(260, 20);
            this.mcNoTextBox.TabIndex = 34;
            // 
            // mcLabel
            // 
            this.mcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mcLabel.AutoSize = true;
            this.mcLabel.Location = new System.Drawing.Point(882, 94);
            this.mcLabel.Name = "mcLabel";
            this.mcLabel.Size = new System.Drawing.Size(30, 13);
            this.mcLabel.TabIndex = 33;
            this.mcLabel.Text = "MC#";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Location = new System.Drawing.Point(920, 65);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(260, 20);
            this.phoneTextBox.TabIndex = 32;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(876, 68);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 31;
            this.phoneLabel.Text = "Phone";
            // 
            // legalNameTextBox
            // 
            this.legalNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.legalNameTextBox.Location = new System.Drawing.Point(927, 12);
            this.legalNameTextBox.Name = "legalNameTextBox";
            this.legalNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.legalNameTextBox.TabIndex = 30;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(865, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 13);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Legal Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 595);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(1092, 584);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(109, 23);
            this.quitBtn.TabIndex = 27;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // clearAirlineBtn
            // 
            this.clearAirlineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAirlineBtn.Location = new System.Drawing.Point(865, 584);
            this.clearAirlineBtn.Name = "clearAirlineBtn";
            this.clearAirlineBtn.Size = new System.Drawing.Size(221, 23);
            this.clearAirlineBtn.TabIndex = 26;
            this.clearAirlineBtn.Text = "Clear Airline";
            this.clearAirlineBtn.UseVisualStyleBackColor = true;
            this.clearAirlineBtn.Click += new System.EventHandler(this.clearAirlineBtn_Click);
            // 
            // dbaNameTextBox
            // 
            this.dbaNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dbaNameTextBox.Location = new System.Drawing.Point(927, 38);
            this.dbaNameTextBox.Name = "dbaNameTextBox";
            this.dbaNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.dbaNameTextBox.TabIndex = 47;
            // 
            // dbaNameLabel
            // 
            this.dbaNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dbaNameLabel.AutoSize = true;
            this.dbaNameLabel.Location = new System.Drawing.Point(869, 41);
            this.dbaNameLabel.Name = "dbaNameLabel";
            this.dbaNameLabel.Size = new System.Drawing.Size(60, 13);
            this.dbaNameLabel.TabIndex = 46;
            this.dbaNameLabel.Text = "DBA Name";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(949, 274);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(231, 20);
            this.passwordTextBox.TabIndex = 108;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(890, 277);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 107;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(930, 248);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(250, 20);
            this.usernameTextBox.TabIndex = 106;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(869, 251);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 105;
            this.usernameLabel.Text = "Username";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(959, 300);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(221, 20);
            this.confirmPasswordTextBox.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(865, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Confirm Password";
            // 
            // AdminAirlineOperatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 622);
            this.ControlBox = false;
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.dbaNameTextBox);
            this.Controls.Add(this.dbaNameLabel);
            this.Controls.Add(this.deleteAirlineBtn);
            this.Controls.Add(this.updateAirlineBtn);
            this.Controls.Add(this.addAirlineBtn);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.companyAddressLabel);
            this.Controls.Add(this.mcNoTextBox);
            this.Controls.Add(this.mcLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.legalNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.clearAirlineBtn);
            this.MinimumSize = new System.Drawing.Size(1233, 661);
            this.Name = "AdminAirlineOperatorUI";
            this.Text = "Admin Airline Operator Interface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminAirlineOperatorUI_Load);
            this.Shown += new System.EventHandler(this.AdminAirlineOperatorUI_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button deleteAirlineBtn;
        private System.Windows.Forms.Button updateAirlineBtn;
        private System.Windows.Forms.Button addAirlineBtn;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button clearAirlineBtn;
        private System.Windows.Forms.TextBox dbaNameTextBox;
        private System.Windows.Forms.Label dbaNameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label label1;
    }
}