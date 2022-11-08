namespace WindowsFormsApp2
{
    partial class AirlineOperatorDeleteFlight
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
            this.backLabel = new System.Windows.Forms.Label();
            this.bookedTicketsLabel = new System.Windows.Forms.Label();
            this.clearFlightBtn = new System.Windows.Forms.Button();
            this.deleteFlightBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.flightNameTextBox = new System.Windows.Forms.TextBox();
            this.flightNameLabel = new System.Windows.Forms.Label();
            this.departDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dcountryTextBox = new System.Windows.Forms.TextBox();
            this.scityTextBox = new System.Windows.Forms.TextBox();
            this.dcityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.scountryTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userGuideLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Location = new System.Drawing.Point(12, 9);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(32, 13);
            this.backLabel.TabIndex = 20;
            this.backLabel.Text = "Back";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // bookedTicketsLabel
            // 
            this.bookedTicketsLabel.AutoSize = true;
            this.bookedTicketsLabel.Location = new System.Drawing.Point(450, 10);
            this.bookedTicketsLabel.Name = "bookedTicketsLabel";
            this.bookedTicketsLabel.Size = new System.Drawing.Size(82, 13);
            this.bookedTicketsLabel.TabIndex = 18;
            this.bookedTicketsLabel.Text = "Booked Tickets";
            // 
            // clearFlightBtn
            // 
            this.clearFlightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearFlightBtn.Location = new System.Drawing.Point(11, 560);
            this.clearFlightBtn.Name = "clearFlightBtn";
            this.clearFlightBtn.Size = new System.Drawing.Size(209, 48);
            this.clearFlightBtn.TabIndex = 17;
            this.clearFlightBtn.Text = "Clear Flight Information";
            this.clearFlightBtn.UseVisualStyleBackColor = true;
            this.clearFlightBtn.Click += new System.EventHandler(this.clearFlightBtn_Click);
            // 
            // deleteFlightBtn
            // 
            this.deleteFlightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteFlightBtn.Location = new System.Drawing.Point(226, 560);
            this.deleteFlightBtn.Name = "deleteFlightBtn";
            this.deleteFlightBtn.Size = new System.Drawing.Size(210, 47);
            this.deleteFlightBtn.TabIndex = 16;
            this.deleteFlightBtn.Text = "Delete Flight";
            this.deleteFlightBtn.UseVisualStyleBackColor = true;
            this.deleteFlightBtn.Click += new System.EventHandler(this.deleteFlightBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flightIdTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.flightNameTextBox);
            this.groupBox1.Controls.Add(this.flightNameLabel);
            this.groupBox1.Controls.Add(this.departDateTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dcountryTextBox);
            this.groupBox1.Controls.Add(this.scityTextBox);
            this.groupBox1.Controls.Add(this.dcityTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.scountryTextBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 352);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Ticket Info";
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Location = new System.Drawing.Point(68, 48);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(253, 20);
            this.flightIdTextBox.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "Flight ID";
            // 
            // flightNameTextBox
            // 
            this.flightNameTextBox.Location = new System.Drawing.Point(68, 22);
            this.flightNameTextBox.Name = "flightNameTextBox";
            this.flightNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.flightNameTextBox.TabIndex = 89;
            // 
            // flightNameLabel
            // 
            this.flightNameLabel.AutoSize = true;
            this.flightNameLabel.Location = new System.Drawing.Point(6, 25);
            this.flightNameLabel.Name = "flightNameLabel";
            this.flightNameLabel.Size = new System.Drawing.Size(63, 13);
            this.flightNameLabel.TabIndex = 88;
            this.flightNameLabel.Text = "Flight Name";
            // 
            // departDateTextBox
            // 
            this.departDateTextBox.Location = new System.Drawing.Point(91, 271);
            this.departDateTextBox.Name = "departDateTextBox";
            this.departDateTextBox.Size = new System.Drawing.Size(334, 20);
            this.departDateTextBox.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Departure Date";
            // 
            // dcountryTextBox
            // 
            this.dcountryTextBox.Location = new System.Drawing.Point(139, 226);
            this.dcountryTextBox.Name = "dcountryTextBox";
            this.dcountryTextBox.Size = new System.Drawing.Size(286, 20);
            this.dcountryTextBox.TabIndex = 85;
            // 
            // scityTextBox
            // 
            this.scityTextBox.Location = new System.Drawing.Point(139, 121);
            this.scityTextBox.Name = "scityTextBox";
            this.scityTextBox.Size = new System.Drawing.Size(286, 20);
            this.scityTextBox.TabIndex = 79;
            // 
            // dcityTextBox
            // 
            this.dcityTextBox.Location = new System.Drawing.Point(139, 202);
            this.dcityTextBox.Name = "dcityTextBox";
            this.dcityTextBox.Size = new System.Drawing.Size(286, 20);
            this.dcityTextBox.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Source Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "City, State Zip Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "City, State Zip Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Destination Address";
            // 
            // scountryTextBox
            // 
            this.scountryTextBox.Location = new System.Drawing.Point(139, 145);
            this.scountryTextBox.Name = "scountryTextBox";
            this.scountryTextBox.Size = new System.Drawing.Size(286, 20);
            this.scountryTextBox.TabIndex = 80;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 579);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // userGuideLabel
            // 
            this.userGuideLabel.AutoSize = true;
            this.userGuideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuideLabel.ForeColor = System.Drawing.Color.Red;
            this.userGuideLabel.Location = new System.Drawing.Point(6, 29);
            this.userGuideLabel.Name = "userGuideLabel";
            this.userGuideLabel.Size = new System.Drawing.Size(441, 25);
            this.userGuideLabel.TabIndex = 19;
            this.userGuideLabel.Text = "NOTE: You can only delete those Flights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Whose tickets haven\'t been sold yet";
            // 
            // AirlineOperatorDeleteFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 645);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.userGuideLabel);
            this.Controls.Add(this.bookedTicketsLabel);
            this.Controls.Add(this.clearFlightBtn);
            this.Controls.Add(this.deleteFlightBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AirlineOperatorDeleteFlight";
            this.Text = "AirlineOperatorDeleteFlight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AirlineOperatorDeleteFlight_Load);
            this.Shown += new System.EventHandler(this.AirlineOperatorDeleteFlight_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label bookedTicketsLabel;
        private System.Windows.Forms.Button clearFlightBtn;
        private System.Windows.Forms.Button deleteFlightBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox flightNameTextBox;
        private System.Windows.Forms.Label flightNameLabel;
        private System.Windows.Forms.TextBox departDateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dcountryTextBox;
        private System.Windows.Forms.TextBox scityTextBox;
        private System.Windows.Forms.TextBox dcityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox scountryTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label userGuideLabel;
        private System.Windows.Forms.Label label1;
    }
}