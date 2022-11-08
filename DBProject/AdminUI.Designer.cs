namespace WindowsFormsApp2
{
    partial class AdminUI
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.flightAvailTicketLabel = new System.Windows.Forms.Label();
            this.airlineOperatorLabel = new System.Windows.Forms.Label();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.airportLabel = new System.Windows.Forms.Label();
            this.cancelTicketLabel = new System.Windows.Forms.Label();
            this.flightAirportOperatedLabel = new System.Windows.Forms.Label();
            this.flightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1000, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(155, 23);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Log Out as Admin";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Tables in Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Double Click to Open More Detail about Table";
            // 
            // ticketLabel
            // 
            this.ticketLabel.Location = new System.Drawing.Point(0, 0);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(100, 23);
            this.ticketLabel.TabIndex = 25;
            // 
            // flightAvailTicketLabel
            // 
            this.flightAvailTicketLabel.Location = new System.Drawing.Point(0, 0);
            this.flightAvailTicketLabel.Name = "flightAvailTicketLabel";
            this.flightAvailTicketLabel.Size = new System.Drawing.Size(100, 23);
            this.flightAvailTicketLabel.TabIndex = 24;
            // 
            // airlineOperatorLabel
            // 
            this.airlineOperatorLabel.AutoSize = true;
            this.airlineOperatorLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineOperatorLabel.Location = new System.Drawing.Point(10, 212);
            this.airlineOperatorLabel.Name = "airlineOperatorLabel";
            this.airlineOperatorLabel.Size = new System.Drawing.Size(170, 27);
            this.airlineOperatorLabel.TabIndex = 9;
            this.airlineOperatorLabel.Text = "Airline Operator";
            this.airlineOperatorLabel.Click += new System.EventHandler(this.airlineOperatorLabel_Click);
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLabel.Location = new System.Drawing.Point(12, 239);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(108, 27);
            this.passengerLabel.TabIndex = 11;
            this.passengerLabel.Text = "Passenger";
            this.passengerLabel.Click += new System.EventHandler(this.passengerLabel_Click_1);
            // 
            // airportLabel
            // 
            this.airportLabel.AutoSize = true;
            this.airportLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportLabel.Location = new System.Drawing.Point(12, 266);
            this.airportLabel.Name = "airportLabel";
            this.airportLabel.Size = new System.Drawing.Size(82, 27);
            this.airportLabel.TabIndex = 13;
            this.airportLabel.Text = "Airport";
            this.airportLabel.Click += new System.EventHandler(this.airportLabel_Click);
            // 
            // cancelTicketLabel
            // 
            this.cancelTicketLabel.Location = new System.Drawing.Point(0, 0);
            this.cancelTicketLabel.Name = "cancelTicketLabel";
            this.cancelTicketLabel.Size = new System.Drawing.Size(100, 23);
            this.cancelTicketLabel.TabIndex = 23;
            // 
            // flightAirportOperatedLabel
            // 
            this.flightAirportOperatedLabel.Location = new System.Drawing.Point(0, 0);
            this.flightAirportOperatedLabel.Name = "flightAirportOperatedLabel";
            this.flightAirportOperatedLabel.Size = new System.Drawing.Size(100, 23);
            this.flightAirportOperatedLabel.TabIndex = 22;
            // 
            // flightLabel
            // 
            this.flightLabel.Location = new System.Drawing.Point(0, 0);
            this.flightLabel.Name = "flightLabel";
            this.flightLabel.Size = new System.Drawing.Size(100, 23);
            this.flightLabel.TabIndex = 0;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 622);
            this.ControlBox = false;
            this.Controls.Add(this.flightLabel);
            this.Controls.Add(this.flightAirportOperatedLabel);
            this.Controls.Add(this.cancelTicketLabel);
            this.Controls.Add(this.airportLabel);
            this.Controls.Add(this.passengerLabel);
            this.Controls.Add(this.airlineOperatorLabel);
            this.Controls.Add(this.flightAvailTicketLabel);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.MinimumSize = new System.Drawing.Size(1233, 661);
            this.Name = "AdminUI";
            this.Text = "Admin User Interface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.Label flightAvailTicketLabel;
        private System.Windows.Forms.Label airlineOperatorLabel;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.Label airportLabel;
        private System.Windows.Forms.Label cancelTicketLabel;
        private System.Windows.Forms.Label flightAirportOperatedLabel;
        private System.Windows.Forms.Label flightLabel;
    }
}