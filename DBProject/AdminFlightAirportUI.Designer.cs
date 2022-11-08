namespace WindowsFormsApp2
{
    partial class AdminFlightAirportUI
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
            this.airportIdTextBox = new System.Windows.Forms.TextBox();
            this.airportIdLabel = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.whereTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quitBtn = new System.Windows.Forms.Button();
            this.clearEntityBtn = new System.Windows.Forms.Button();
            this.saveEntityBtn = new System.Windows.Forms.Button();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.flightIdLabel = new System.Windows.Forms.Label();
            this.addEntityBtn = new System.Windows.Forms.Button();
            this.updateEntityBtn = new System.Windows.Forms.Button();
            this.deleteEntityBtn = new System.Windows.Forms.Button();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // airportIdTextBox
            // 
            this.airportIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.airportIdTextBox.Location = new System.Drawing.Point(929, 40);
            this.airportIdTextBox.Name = "airportIdTextBox";
            this.airportIdTextBox.Size = new System.Drawing.Size(253, 20);
            this.airportIdTextBox.TabIndex = 105;
            // 
            // airportIdLabel
            // 
            this.airportIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.airportIdLabel.AutoSize = true;
            this.airportIdLabel.Location = new System.Drawing.Point(873, 43);
            this.airportIdLabel.Name = "airportIdLabel";
            this.airportIdLabel.Size = new System.Drawing.Size(51, 13);
            this.airportIdLabel.TabIndex = 104;
            this.airportIdLabel.Text = "Airport ID";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGroupBox.Controls.Add(this.whereTextBox);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.fromLabel);
            this.searchGroupBox.Controls.Add(this.selectComboBox);
            this.searchGroupBox.Controls.Add(this.selectLabel);
            this.searchGroupBox.Location = new System.Drawing.Point(868, 400);
            this.searchGroupBox.MinimumSize = new System.Drawing.Size(335, 150);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(335, 151);
            this.searchGroupBox.TabIndex = 89;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // whereTextBox
            // 
            this.whereTextBox.Location = new System.Drawing.Point(61, 45);
            this.whereTextBox.Multiline = true;
            this.whereTextBox.Name = "whereTextBox";
            this.whereTextBox.Size = new System.Drawing.Size(253, 95);
            this.whereTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "WHERE";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(188, 20);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(130, 13);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "FROM FLIGHT-AIRPORT";
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Items.AddRange(new object[] {
            "*",
            "TicketNo",
            "Price",
            "Seat No",
            "PassengerID",
            "FlightID",
            "InvoiceID"});
            this.selectComboBox.Location = new System.Drawing.Point(61, 17);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectComboBox.TabIndex = 1;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(7, 20);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(48, 13);
            this.selectLabel.TabIndex = 0;
            this.selectLabel.Text = "SELECT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 595);
            this.dataGridView1.TabIndex = 88;
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(1094, 586);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(109, 23);
            this.quitBtn.TabIndex = 87;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // clearEntityBtn
            // 
            this.clearEntityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearEntityBtn.Location = new System.Drawing.Point(979, 586);
            this.clearEntityBtn.Name = "clearEntityBtn";
            this.clearEntityBtn.Size = new System.Drawing.Size(109, 23);
            this.clearEntityBtn.TabIndex = 86;
            this.clearEntityBtn.Text = "Clear Entity";
            this.clearEntityBtn.UseVisualStyleBackColor = true;
            // 
            // saveEntityBtn
            // 
            this.saveEntityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEntityBtn.Location = new System.Drawing.Point(867, 586);
            this.saveEntityBtn.Name = "saveEntityBtn";
            this.saveEntityBtn.Size = new System.Drawing.Size(106, 23);
            this.saveEntityBtn.TabIndex = 85;
            this.saveEntityBtn.Text = "Save Entity";
            this.saveEntityBtn.UseVisualStyleBackColor = true;
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flightIdTextBox.Location = new System.Drawing.Point(929, 66);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(253, 20);
            this.flightIdTextBox.TabIndex = 107;
            // 
            // flightIdLabel
            // 
            this.flightIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flightIdLabel.AutoSize = true;
            this.flightIdLabel.Location = new System.Drawing.Point(878, 69);
            this.flightIdLabel.Name = "flightIdLabel";
            this.flightIdLabel.Size = new System.Drawing.Size(46, 13);
            this.flightIdLabel.TabIndex = 106;
            this.flightIdLabel.Text = "Flight ID";
            // 
            // addEntityBtn
            // 
            this.addEntityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addEntityBtn.Location = new System.Drawing.Point(867, 557);
            this.addEntityBtn.Name = "addEntityBtn";
            this.addEntityBtn.Size = new System.Drawing.Size(106, 23);
            this.addEntityBtn.TabIndex = 90;
            this.addEntityBtn.Text = "Add Entity";
            this.addEntityBtn.UseVisualStyleBackColor = true;
            // 
            // updateEntityBtn
            // 
            this.updateEntityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateEntityBtn.Location = new System.Drawing.Point(979, 557);
            this.updateEntityBtn.Name = "updateEntityBtn";
            this.updateEntityBtn.Size = new System.Drawing.Size(109, 23);
            this.updateEntityBtn.TabIndex = 91;
            this.updateEntityBtn.Text = "Update Entity";
            this.updateEntityBtn.UseVisualStyleBackColor = true;
            // 
            // deleteEntityBtn
            // 
            this.deleteEntityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEntityBtn.Location = new System.Drawing.Point(1094, 557);
            this.deleteEntityBtn.Name = "deleteEntityBtn";
            this.deleteEntityBtn.Size = new System.Drawing.Size(109, 23);
            this.deleteEntityBtn.TabIndex = 92;
            this.deleteEntityBtn.Text = "Delete Entity";
            this.deleteEntityBtn.UseVisualStyleBackColor = true;
            // 
            // AdminFlightAirportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 622);
            this.Controls.Add(this.flightIdTextBox);
            this.Controls.Add(this.flightIdLabel);
            this.Controls.Add(this.airportIdTextBox);
            this.Controls.Add(this.airportIdLabel);
            this.Controls.Add(this.deleteEntityBtn);
            this.Controls.Add(this.updateEntityBtn);
            this.Controls.Add(this.addEntityBtn);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.clearEntityBtn);
            this.Controls.Add(this.saveEntityBtn);
            this.MinimumSize = new System.Drawing.Size(1233, 661);
            this.Name = "AdminFlightAirportUI";
            this.Text = "AdminTimetableUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminFlightAirportUI_FormClosed);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox airportIdTextBox;
        private System.Windows.Forms.Label airportIdLabel;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox whereTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button clearEntityBtn;
        private System.Windows.Forms.Button saveEntityBtn;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.Label flightIdLabel;
        private System.Windows.Forms.Button addEntityBtn;
        private System.Windows.Forms.Button updateEntityBtn;
        private System.Windows.Forms.Button deleteEntityBtn;
    }
}