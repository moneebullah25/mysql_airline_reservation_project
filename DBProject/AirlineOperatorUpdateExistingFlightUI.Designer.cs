namespace WindowsFormsApp2
{
    partial class AirlineOperatorUpdateExistingFlightUI
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
            System.Windows.Forms.Button infoBtn;
            this.userGuideBtn = new System.Windows.Forms.Button();
            this.backLabel = new System.Windows.Forms.Label();
            this.clearFlightBtn = new System.Windows.Forms.Button();
            this.updateFlightBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.airportIDTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.arrivalDateTextBox = new System.Windows.Forms.TextBox();
            this.flightNameTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateLabel = new System.Windows.Forms.Label();
            this.flightNameLabel = new System.Windows.Forms.Label();
            this.departDateTextBox2 = new System.Windows.Forms.TextBox();
            this.noofSeatsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noofSeatsTextBox = new System.Windows.Forms.TextBox();
            this.fdcountryTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fdcityTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fscityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fscountryTextBox = new System.Windows.Forms.TextBox();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.departDateTextBox = new System.Windows.Forms.TextBox();
            this.departDateLabel = new System.Windows.Forms.Label();
            this.dcountryTextBox = new System.Windows.Forms.TextBox();
            this.scityTextBox = new System.Windows.Forms.TextBox();
            this.dcityTextBox = new System.Windows.Forms.TextBox();
            this.sourceAddressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.destinationAddressLabel = new System.Windows.Forms.Label();
            this.scountryTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            infoBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBtn
            // 
            infoBtn.Location = new System.Drawing.Point(12, 257);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new System.Drawing.Size(283, 23);
            infoBtn.TabIndex = 16;
            infoBtn.Text = "Double click on Flight in Data Grid View to Update info";
            infoBtn.UseVisualStyleBackColor = true;
            // 
            // userGuideBtn
            // 
            this.userGuideBtn.Location = new System.Drawing.Point(50, 10);
            this.userGuideBtn.Name = "userGuideBtn";
            this.userGuideBtn.Size = new System.Drawing.Size(387, 23);
            this.userGuideBtn.TabIndex = 14;
            this.userGuideBtn.UseVisualStyleBackColor = true;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Location = new System.Drawing.Point(12, 15);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(32, 13);
            this.backLabel.TabIndex = 13;
            this.backLabel.Text = "Back";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // clearFlightBtn
            // 
            this.clearFlightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearFlightBtn.Location = new System.Drawing.Point(13, 582);
            this.clearFlightBtn.Name = "clearFlightBtn";
            this.clearFlightBtn.Size = new System.Drawing.Size(209, 31);
            this.clearFlightBtn.TabIndex = 12;
            this.clearFlightBtn.Text = "Clear Flight Information";
            this.clearFlightBtn.UseVisualStyleBackColor = true;
            this.clearFlightBtn.Click += new System.EventHandler(this.clearFlightBtn_Click);
            // 
            // updateFlightBtn
            // 
            this.updateFlightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateFlightBtn.Location = new System.Drawing.Point(228, 582);
            this.updateFlightBtn.Name = "updateFlightBtn";
            this.updateFlightBtn.Size = new System.Drawing.Size(210, 30);
            this.updateFlightBtn.TabIndex = 11;
            this.updateFlightBtn.Text = "Update Flight Information";
            this.updateFlightBtn.UseVisualStyleBackColor = true;
            this.updateFlightBtn.Click += new System.EventHandler(this.updateFlightBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.airportIDTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.arrivalDateTextBox);
            this.groupBox1.Controls.Add(this.flightNameTextBox);
            this.groupBox1.Controls.Add(this.arrivalDateLabel);
            this.groupBox1.Controls.Add(this.flightNameLabel);
            this.groupBox1.Controls.Add(this.departDateTextBox2);
            this.groupBox1.Controls.Add(this.noofSeatsLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.noofSeatsTextBox);
            this.groupBox1.Controls.Add(this.fdcountryTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.fdcityTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fscityTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fscountryTextBox);
            this.groupBox1.Controls.Add(this.flightIdTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(13, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 296);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Flight Info";
            // 
            // airportIDTextBox
            // 
            this.airportIDTextBox.Location = new System.Drawing.Point(269, 124);
            this.airportIDTextBox.Name = "airportIDTextBox";
            this.airportIDTextBox.Size = new System.Drawing.Size(154, 20);
            this.airportIDTextBox.TabIndex = 121;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 120;
            this.label13.Text = "Airport ID";
            // 
            // arrivalDateTextBox
            // 
            this.arrivalDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalDateTextBox.Location = new System.Drawing.Point(68, 124);
            this.arrivalDateTextBox.Name = "arrivalDateTextBox";
            this.arrivalDateTextBox.Size = new System.Drawing.Size(141, 20);
            this.arrivalDateTextBox.TabIndex = 119;
            // 
            // flightNameTextBox
            // 
            this.flightNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightNameTextBox.Location = new System.Drawing.Point(68, 19);
            this.flightNameTextBox.Name = "flightNameTextBox";
            this.flightNameTextBox.Size = new System.Drawing.Size(356, 20);
            this.flightNameTextBox.TabIndex = 101;
            // 
            // arrivalDateLabel
            // 
            this.arrivalDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalDateLabel.AutoSize = true;
            this.arrivalDateLabel.Location = new System.Drawing.Point(6, 127);
            this.arrivalDateLabel.Name = "arrivalDateLabel";
            this.arrivalDateLabel.Size = new System.Drawing.Size(62, 13);
            this.arrivalDateLabel.TabIndex = 118;
            this.arrivalDateLabel.Text = "Arrival Date";
            // 
            // flightNameLabel
            // 
            this.flightNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightNameLabel.AutoSize = true;
            this.flightNameLabel.Location = new System.Drawing.Point(6, 22);
            this.flightNameLabel.Name = "flightNameLabel";
            this.flightNameLabel.Size = new System.Drawing.Size(63, 13);
            this.flightNameLabel.TabIndex = 100;
            this.flightNameLabel.Text = "Flight Name";
            // 
            // departDateTextBox2
            // 
            this.departDateTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departDateTextBox2.Location = new System.Drawing.Point(68, 98);
            this.departDateTextBox2.Name = "departDateTextBox2";
            this.departDateTextBox2.Size = new System.Drawing.Size(356, 20);
            this.departDateTextBox2.TabIndex = 117;
            // 
            // noofSeatsLabel
            // 
            this.noofSeatsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noofSeatsLabel.AutoSize = true;
            this.noofSeatsLabel.Location = new System.Drawing.Point(2, 75);
            this.noofSeatsLabel.Name = "noofSeatsLabel";
            this.noofSeatsLabel.Size = new System.Drawing.Size(63, 13);
            this.noofSeatsLabel.TabIndex = 102;
            this.noofSeatsLabel.Text = "No of Seats";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Depart Date";
            // 
            // noofSeatsTextBox
            // 
            this.noofSeatsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noofSeatsTextBox.Location = new System.Drawing.Point(68, 72);
            this.noofSeatsTextBox.Name = "noofSeatsTextBox";
            this.noofSeatsTextBox.Size = new System.Drawing.Size(356, 20);
            this.noofSeatsTextBox.TabIndex = 103;
            // 
            // fdcountryTextBox
            // 
            this.fdcountryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fdcountryTextBox.Location = new System.Drawing.Point(139, 263);
            this.fdcountryTextBox.Name = "fdcountryTextBox";
            this.fdcountryTextBox.Size = new System.Drawing.Size(284, 20);
            this.fdcountryTextBox.TabIndex = 115;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 104;
            this.label11.Text = "Source Address";
            // 
            // fdcityTextBox
            // 
            this.fdcityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fdcityTextBox.Location = new System.Drawing.Point(139, 239);
            this.fdcityTextBox.Name = "fdcityTextBox";
            this.fdcityTextBox.Size = new System.Drawing.Size(284, 20);
            this.fdcityTextBox.TabIndex = 114;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 105;
            this.label10.Text = "City, State Zip Code";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 113;
            this.label5.Text = "Country";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 106;
            this.label9.Text = "Country";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 112;
            this.label6.Text = "City, State Zip Code";
            // 
            // fscityTextBox
            // 
            this.fscityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fscityTextBox.Location = new System.Drawing.Point(140, 175);
            this.fscityTextBox.Name = "fscityTextBox";
            this.fscityTextBox.Size = new System.Drawing.Size(284, 20);
            this.fscityTextBox.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "Destination Address";
            // 
            // fscountryTextBox
            // 
            this.fscountryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fscountryTextBox.Location = new System.Drawing.Point(140, 199);
            this.fscountryTextBox.Name = "fscountryTextBox";
            this.fscountryTextBox.Size = new System.Drawing.Size(284, 20);
            this.fscountryTextBox.TabIndex = 108;
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightIdTextBox.Location = new System.Drawing.Point(68, 45);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(356, 20);
            this.flightIdTextBox.TabIndex = 110;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 109;
            this.label8.Text = "Flight ID";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.textBox6);
            this.searchGroupBox.Controls.Add(this.label2);
            this.searchGroupBox.Controls.Add(this.textBox7);
            this.searchGroupBox.Controls.Add(this.label12);
            this.searchGroupBox.Controls.Add(this.departDateTextBox);
            this.searchGroupBox.Controls.Add(this.departDateLabel);
            this.searchGroupBox.Controls.Add(this.dcountryTextBox);
            this.searchGroupBox.Controls.Add(this.scityTextBox);
            this.searchGroupBox.Controls.Add(this.dcityTextBox);
            this.searchGroupBox.Controls.Add(this.sourceAddressLabel);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.cityLabel);
            this.searchGroupBox.Controls.Add(this.label3);
            this.searchGroupBox.Controls.Add(this.countryLabel);
            this.searchGroupBox.Controls.Add(this.destinationAddressLabel);
            this.searchGroupBox.Controls.Add(this.scountryTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 38);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(432, 213);
            this.searchGroupBox.TabIndex = 9;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search For Flight Tickets";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(260, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 20);
            this.textBox6.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Flight ID";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(69, 19);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(126, 20);
            this.textBox7.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 91;
            this.label12.Text = "Flight Name";
            // 
            // departDateTextBox
            // 
            this.departDateTextBox.Location = new System.Drawing.Point(92, 186);
            this.departDateTextBox.Name = "departDateTextBox";
            this.departDateTextBox.Size = new System.Drawing.Size(334, 20);
            this.departDateTextBox.TabIndex = 87;
            // 
            // departDateLabel
            // 
            this.departDateLabel.AutoSize = true;
            this.departDateLabel.Location = new System.Drawing.Point(6, 189);
            this.departDateLabel.Name = "departDateLabel";
            this.departDateLabel.Size = new System.Drawing.Size(80, 13);
            this.departDateLabel.TabIndex = 86;
            this.departDateLabel.Text = "Departure Date";
            // 
            // dcountryTextBox
            // 
            this.dcountryTextBox.Location = new System.Drawing.Point(140, 160);
            this.dcountryTextBox.Name = "dcountryTextBox";
            this.dcountryTextBox.Size = new System.Drawing.Size(286, 20);
            this.dcountryTextBox.TabIndex = 85;
            // 
            // scityTextBox
            // 
            this.scityTextBox.Location = new System.Drawing.Point(140, 70);
            this.scityTextBox.Name = "scityTextBox";
            this.scityTextBox.Size = new System.Drawing.Size(286, 20);
            this.scityTextBox.TabIndex = 79;
            // 
            // dcityTextBox
            // 
            this.dcityTextBox.Location = new System.Drawing.Point(140, 136);
            this.dcityTextBox.Name = "dcityTextBox";
            this.dcityTextBox.Size = new System.Drawing.Size(286, 20);
            this.dcityTextBox.TabIndex = 84;
            // 
            // sourceAddressLabel
            // 
            this.sourceAddressLabel.AutoSize = true;
            this.sourceAddressLabel.Location = new System.Drawing.Point(6, 52);
            this.sourceAddressLabel.Name = "sourceAddressLabel";
            this.sourceAddressLabel.Size = new System.Drawing.Size(82, 13);
            this.sourceAddressLabel.TabIndex = 76;
            this.sourceAddressLabel.Text = "Source Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(30, 73);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(101, 13);
            this.cityLabel.TabIndex = 77;
            this.cityLabel.Text = "City, State Zip Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "City, State Zip Code";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(91, 97);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 78;
            this.countryLabel.Text = "Country";
            // 
            // destinationAddressLabel
            // 
            this.destinationAddressLabel.AutoSize = true;
            this.destinationAddressLabel.Location = new System.Drawing.Point(6, 118);
            this.destinationAddressLabel.Name = "destinationAddressLabel";
            this.destinationAddressLabel.Size = new System.Drawing.Size(101, 13);
            this.destinationAddressLabel.TabIndex = 81;
            this.destinationAddressLabel.Text = "Destination Address";
            // 
            // scountryTextBox
            // 
            this.scountryTextBox.Location = new System.Drawing.Point(140, 94);
            this.scountryTextBox.Name = "scountryTextBox";
            this.scountryTextBox.Size = new System.Drawing.Size(286, 20);
            this.scountryTextBox.TabIndex = 80;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(451, 15);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(754, 598);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(301, 257);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(137, 23);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // AirlineOperatorUpdateExistingFlightUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 622);
            this.ControlBox = false;
            this.Controls.Add(infoBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.userGuideBtn);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.clearFlightBtn);
            this.Controls.Add(this.updateFlightBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.dataGridView);
            this.MinimumSize = new System.Drawing.Size(1233, 661);
            this.Name = "AirlineOperatorUpdateExistingFlightUI";
            this.Text = "AirlineOperatorUpdateExistingFlightUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AirlineOperatorUpdateExistingFlightUI_Load);
            this.Shown += new System.EventHandler(this.AirlineOperatorUpdateExistingFlightUI_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userGuideBtn;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Button clearFlightBtn;
        private System.Windows.Forms.Button updateFlightBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox departDateTextBox;
        private System.Windows.Forms.Label departDateLabel;
        private System.Windows.Forms.TextBox dcountryTextBox;
        private System.Windows.Forms.TextBox scityTextBox;
        private System.Windows.Forms.TextBox dcityTextBox;
        private System.Windows.Forms.Label sourceAddressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label destinationAddressLabel;
        private System.Windows.Forms.TextBox scountryTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrivalDateTextBox;
        private System.Windows.Forms.TextBox flightNameTextBox;
        private System.Windows.Forms.Label arrivalDateLabel;
        private System.Windows.Forms.Label flightNameLabel;
        private System.Windows.Forms.TextBox departDateTextBox2;
        private System.Windows.Forms.Label noofSeatsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox noofSeatsTextBox;
        private System.Windows.Forms.TextBox fdcountryTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fdcityTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fscityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fscountryTextBox;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox airportIDTextBox;
        private System.Windows.Forms.Label label13;
    }
}