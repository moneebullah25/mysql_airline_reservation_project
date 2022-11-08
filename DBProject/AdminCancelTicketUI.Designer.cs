namespace WindowsFormsApp2
{
    partial class AdminCancelTicketUI
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
            this.deleteCancelTicketBtn = new System.Windows.Forms.Button();
            this.updateCancelTicketBtn = new System.Windows.Forms.Button();
            this.addCancelTicketBtn = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.noofSeatsTextBox = new System.Windows.Forms.TextBox();
            this.noofSeatsLabel = new System.Windows.Forms.Label();
            this.passengerIdTextBox = new System.Windows.Forms.TextBox();
            this.passengerIdLabel = new System.Windows.Forms.Label();
            this.passengerNameTextBox = new System.Windows.Forms.TextBox();
            this.passengerNameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quitBtn = new System.Windows.Forms.Button();
            this.clearCancelTicketBtn = new System.Windows.Forms.Button();
            this.saveCancelTicketBtn = new System.Windows.Forms.Button();
            this.cancellationIdTextBox = new System.Windows.Forms.TextBox();
            this.cancellationId = new System.Windows.Forms.Label();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteCancelTicketBtn
            // 
            this.deleteCancelTicketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCancelTicketBtn.Location = new System.Drawing.Point(1094, 543);
            this.deleteCancelTicketBtn.Name = "deleteCancelTicketBtn";
            this.deleteCancelTicketBtn.Size = new System.Drawing.Size(109, 37);
            this.deleteCancelTicketBtn.TabIndex = 45;
            this.deleteCancelTicketBtn.Text = "Delete Cancel Ticket";
            this.deleteCancelTicketBtn.UseVisualStyleBackColor = true;
            // 
            // updateCancelTicketBtn
            // 
            this.updateCancelTicketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateCancelTicketBtn.Location = new System.Drawing.Point(979, 543);
            this.updateCancelTicketBtn.Name = "updateCancelTicketBtn";
            this.updateCancelTicketBtn.Size = new System.Drawing.Size(109, 37);
            this.updateCancelTicketBtn.TabIndex = 44;
            this.updateCancelTicketBtn.Text = "Update Cancel Ticket";
            this.updateCancelTicketBtn.UseVisualStyleBackColor = true;
            // 
            // addCancelTicketBtn
            // 
            this.addCancelTicketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCancelTicketBtn.Location = new System.Drawing.Point(867, 543);
            this.addCancelTicketBtn.Name = "addCancelTicketBtn";
            this.addCancelTicketBtn.Size = new System.Drawing.Size(106, 37);
            this.addCancelTicketBtn.TabIndex = 43;
            this.addCancelTicketBtn.Text = "Add Cancel Ticket";
            this.addCancelTicketBtn.UseVisualStyleBackColor = true;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGroupBox.Controls.Add(this.textBox1);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.fromLabel);
            this.searchGroupBox.Controls.Add(this.comboBox1);
            this.searchGroupBox.Controls.Add(this.selectLabel);
            this.searchGroupBox.Location = new System.Drawing.Point(867, 384);
            this.searchGroupBox.MinimumSize = new System.Drawing.Size(335, 150);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(335, 153);
            this.searchGroupBox.TabIndex = 42;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 95);
            this.textBox1.TabIndex = 4;
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
            this.fromLabel.Size = new System.Drawing.Size(128, 13);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "FROM CANCELTICKETS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "*",
            "CancellationID",
            "PassengerName",
            "PassengerID",
            "NumberOfSeats"});
            this.comboBox1.Location = new System.Drawing.Point(61, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
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
            // noofSeatsTextBox
            // 
            this.noofSeatsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noofSeatsTextBox.Location = new System.Drawing.Point(968, 89);
            this.noofSeatsTextBox.Name = "noofSeatsTextBox";
            this.noofSeatsTextBox.Size = new System.Drawing.Size(211, 20);
            this.noofSeatsTextBox.TabIndex = 34;
            // 
            // noofSeatsLabel
            // 
            this.noofSeatsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noofSeatsLabel.AutoSize = true;
            this.noofSeatsLabel.Location = new System.Drawing.Point(881, 92);
            this.noofSeatsLabel.Name = "noofSeatsLabel";
            this.noofSeatsLabel.Size = new System.Drawing.Size(86, 13);
            this.noofSeatsLabel.TabIndex = 33;
            this.noofSeatsLabel.Text = "Number of Seats";
            // 
            // passengerIdTextBox
            // 
            this.passengerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passengerIdTextBox.Location = new System.Drawing.Point(968, 63);
            this.passengerIdTextBox.Name = "passengerIdTextBox";
            this.passengerIdTextBox.Size = new System.Drawing.Size(211, 20);
            this.passengerIdTextBox.TabIndex = 32;
            // 
            // passengerIdLabel
            // 
            this.passengerIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passengerIdLabel.AutoSize = true;
            this.passengerIdLabel.Location = new System.Drawing.Point(895, 66);
            this.passengerIdLabel.Name = "passengerIdLabel";
            this.passengerIdLabel.Size = new System.Drawing.Size(71, 13);
            this.passengerIdLabel.TabIndex = 31;
            this.passengerIdLabel.Text = "Passenger ID";
            // 
            // passengerNameTextBox
            // 
            this.passengerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passengerNameTextBox.Location = new System.Drawing.Point(968, 37);
            this.passengerNameTextBox.Name = "passengerNameTextBox";
            this.passengerNameTextBox.Size = new System.Drawing.Size(211, 20);
            this.passengerNameTextBox.TabIndex = 30;
            // 
            // passengerNameLabel
            // 
            this.passengerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passengerNameLabel.AutoSize = true;
            this.passengerNameLabel.Location = new System.Drawing.Point(878, 40);
            this.passengerNameLabel.Name = "passengerNameLabel";
            this.passengerNameLabel.Size = new System.Drawing.Size(88, 13);
            this.passengerNameLabel.TabIndex = 29;
            this.passengerNameLabel.Text = "Passenger Name";
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
            this.dataGridView1.TabIndex = 28;
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Location = new System.Drawing.Point(1094, 586);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(109, 23);
            this.quitBtn.TabIndex = 27;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // clearCancelTicketBtn
            // 
            this.clearCancelTicketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCancelTicketBtn.Location = new System.Drawing.Point(979, 586);
            this.clearCancelTicketBtn.Name = "clearCancelTicketBtn";
            this.clearCancelTicketBtn.Size = new System.Drawing.Size(109, 23);
            this.clearCancelTicketBtn.TabIndex = 26;
            this.clearCancelTicketBtn.Text = "Clear Cancel Ticket";
            this.clearCancelTicketBtn.UseVisualStyleBackColor = true;
            // 
            // saveCancelTicketBtn
            // 
            this.saveCancelTicketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveCancelTicketBtn.Location = new System.Drawing.Point(867, 586);
            this.saveCancelTicketBtn.Name = "saveCancelTicketBtn";
            this.saveCancelTicketBtn.Size = new System.Drawing.Size(106, 23);
            this.saveCancelTicketBtn.TabIndex = 25;
            this.saveCancelTicketBtn.Text = "Save Cancel Ticket";
            this.saveCancelTicketBtn.UseVisualStyleBackColor = true;
            // 
            // cancellationIdTextBox
            // 
            this.cancellationIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancellationIdTextBox.Location = new System.Drawing.Point(968, 11);
            this.cancellationIdTextBox.Name = "cancellationIdTextBox";
            this.cancellationIdTextBox.Size = new System.Drawing.Size(211, 20);
            this.cancellationIdTextBox.TabIndex = 47;
            // 
            // cancellationId
            // 
            this.cancellationId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancellationId.AutoSize = true;
            this.cancellationId.Location = new System.Drawing.Point(888, 14);
            this.cancellationId.Name = "cancellationId";
            this.cancellationId.Size = new System.Drawing.Size(79, 13);
            this.cancellationId.TabIndex = 46;
            this.cancellationId.Text = "Cancellation ID";
            // 
            // AdminCancelTicketUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 622);
            this.Controls.Add(this.cancellationIdTextBox);
            this.Controls.Add(this.cancellationId);
            this.Controls.Add(this.deleteCancelTicketBtn);
            this.Controls.Add(this.updateCancelTicketBtn);
            this.Controls.Add(this.addCancelTicketBtn);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.noofSeatsTextBox);
            this.Controls.Add(this.noofSeatsLabel);
            this.Controls.Add(this.passengerIdTextBox);
            this.Controls.Add(this.passengerIdLabel);
            this.Controls.Add(this.passengerNameTextBox);
            this.Controls.Add(this.passengerNameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.clearCancelTicketBtn);
            this.Controls.Add(this.saveCancelTicketBtn);
            this.MinimumSize = new System.Drawing.Size(1233, 661);
            this.Name = "AdminCancelTicketUI";
            this.Text = "Admin Cancel Ticket Interface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminCancelTicketUI_FormClosed);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteCancelTicketBtn;
        private System.Windows.Forms.Button updateCancelTicketBtn;
        private System.Windows.Forms.Button addCancelTicketBtn;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.TextBox noofSeatsTextBox;
        private System.Windows.Forms.Label noofSeatsLabel;
        private System.Windows.Forms.TextBox passengerIdTextBox;
        private System.Windows.Forms.Label passengerIdLabel;
        private System.Windows.Forms.TextBox passengerNameTextBox;
        private System.Windows.Forms.Label passengerNameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button clearCancelTicketBtn;
        private System.Windows.Forms.Button saveCancelTicketBtn;
        private System.Windows.Forms.TextBox cancellationIdTextBox;
        private System.Windows.Forms.Label cancellationId;
    }
}