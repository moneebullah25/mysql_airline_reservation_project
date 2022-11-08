namespace WindowsFormsApp2
{
    partial class AdminAirportUI
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
            this.deleteAirportBtn = new System.Windows.Forms.Button();
            this.updateAirportBtn = new System.Windows.Forms.Button();
            this.addAirportBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quitBtn = new System.Windows.Forms.Button();
            this.clearAirportBtn = new System.Windows.Forms.Button();
            this.airportIdTextBox = new System.Windows.Forms.TextBox();
            this.airportIdLabel = new System.Windows.Forms.Label();
            this.noofFlightsTextBox = new System.Windows.Forms.TextBox();
            this.noofFlightsLabel = new System.Windows.Forms.Label();
            this.airportNameTextBox = new System.Windows.Forms.TextBox();
            this.airportNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteAirportBtn
            // 
            this.deleteAirportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAirportBtn.Location = new System.Drawing.Point(1094, 557);
            this.deleteAirportBtn.Name = "deleteAirportBtn";
            this.deleteAirportBtn.Size = new System.Drawing.Size(109, 23);
            this.deleteAirportBtn.TabIndex = 69;
            this.deleteAirportBtn.Text = "Delete Airport";
            this.deleteAirportBtn.UseVisualStyleBackColor = true;
            this.deleteAirportBtn.Click += new System.EventHandler(this.deleteAirportBtn_Click);
            // 
            // updateAirportBtn
            // 
            this.updateAirportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateAirportBtn.Location = new System.Drawing.Point(979, 557);
            this.updateAirportBtn.Name = "updateAirportBtn";
            this.updateAirportBtn.Size = new System.Drawing.Size(109, 23);
            this.updateAirportBtn.TabIndex = 68;
            this.updateAirportBtn.Text = "Update Airport";
            this.updateAirportBtn.UseVisualStyleBackColor = true;
            this.updateAirportBtn.Click += new System.EventHandler(this.updateAirportBtn_Click);
            // 
            // addAirportBtn
            // 
            this.addAirportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAirportBtn.Location = new System.Drawing.Point(867, 557);
            this.addAirportBtn.Name = "addAirportBtn";
            this.addAirportBtn.Size = new System.Drawing.Size(106, 23);
            this.addAirportBtn.TabIndex = 67;
            this.addAirportBtn.Text = "Add Airport";
            this.addAirportBtn.UseVisualStyleBackColor = true;
            this.addAirportBtn.Click += new System.EventHandler(this.addAirportBtn_Click);
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
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(1094, 586);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(109, 23);
            this.quitBtn.TabIndex = 58;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // clearAirportBtn
            // 
            this.clearAirportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAirportBtn.Location = new System.Drawing.Point(868, 586);
            this.clearAirportBtn.Name = "clearAirportBtn";
            this.clearAirportBtn.Size = new System.Drawing.Size(220, 23);
            this.clearAirportBtn.TabIndex = 57;
            this.clearAirportBtn.Text = "Clear Airport";
            this.clearAirportBtn.UseVisualStyleBackColor = true;
            this.clearAirportBtn.Click += new System.EventHandler(this.clearAirportBtn_Click);
            // 
            // airportIdTextBox
            // 
            this.airportIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.airportIdTextBox.Location = new System.Drawing.Point(929, 40);
            this.airportIdTextBox.Name = "airportIdTextBox";
            this.airportIdTextBox.Size = new System.Drawing.Size(253, 20);
            this.airportIdTextBox.TabIndex = 84;
            // 
            // airportIdLabel
            // 
            this.airportIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.airportIdLabel.AutoSize = true;
            this.airportIdLabel.Location = new System.Drawing.Point(871, 43);
            this.airportIdLabel.Name = "airportIdLabel";
            this.airportIdLabel.Size = new System.Drawing.Size(51, 13);
            this.airportIdLabel.TabIndex = 83;
            this.airportIdLabel.Text = "Airport ID";
            // 
            // noofFlightsTextBox
            // 
            this.noofFlightsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.noofFlightsTextBox.Location = new System.Drawing.Point(929, 67);
            this.noofFlightsTextBox.Name = "noofFlightsTextBox";
            this.noofFlightsTextBox.Size = new System.Drawing.Size(253, 20);
            this.noofFlightsTextBox.TabIndex = 73;
            // 
            // noofFlightsLabel
            // 
            this.noofFlightsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.noofFlightsLabel.AutoSize = true;
            this.noofFlightsLabel.Location = new System.Drawing.Point(863, 70);
            this.noofFlightsLabel.Name = "noofFlightsLabel";
            this.noofFlightsLabel.Size = new System.Drawing.Size(66, 13);
            this.noofFlightsLabel.TabIndex = 72;
            this.noofFlightsLabel.Text = "No of Flights";
            // 
            // airportNameTextBox
            // 
            this.airportNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.airportNameTextBox.Location = new System.Drawing.Point(929, 14);
            this.airportNameTextBox.Name = "airportNameTextBox";
            this.airportNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.airportNameTextBox.TabIndex = 71;
            // 
            // airportNameLabel
            // 
            this.airportNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.airportNameLabel.AutoSize = true;
            this.airportNameLabel.Location = new System.Drawing.Point(863, 17);
            this.airportNameLabel.Name = "airportNameLabel";
            this.airportNameLabel.Size = new System.Drawing.Size(68, 13);
            this.airportNameLabel.TabIndex = 70;
            this.airportNameLabel.Text = "Airport Name";
            // 
            // AdminAirportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 622);
            this.ControlBox = false;
            this.Controls.Add(this.airportIdTextBox);
            this.Controls.Add(this.airportIdLabel);
            this.Controls.Add(this.noofFlightsTextBox);
            this.Controls.Add(this.noofFlightsLabel);
            this.Controls.Add(this.airportNameTextBox);
            this.Controls.Add(this.airportNameLabel);
            this.Controls.Add(this.deleteAirportBtn);
            this.Controls.Add(this.updateAirportBtn);
            this.Controls.Add(this.addAirportBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.clearAirportBtn);
            this.MinimumSize = new System.Drawing.Size(1233, 661);
            this.Name = "AdminAirportUI";
            this.Text = "AdminAirportUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminAirportUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteAirportBtn;
        private System.Windows.Forms.Button updateAirportBtn;
        private System.Windows.Forms.Button addAirportBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button clearAirportBtn;
        private System.Windows.Forms.TextBox airportIdTextBox;
        private System.Windows.Forms.Label airportIdLabel;
        private System.Windows.Forms.TextBox noofFlightsTextBox;
        private System.Windows.Forms.Label noofFlightsLabel;
        private System.Windows.Forms.TextBox airportNameTextBox;
        private System.Windows.Forms.Label airportNameLabel;
    }
}