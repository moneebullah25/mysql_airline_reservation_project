using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PassengerCancelTicket : Form
    {
        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;

        public PassengerCancelTicket()
        {
            InitializeComponent();
        }

        private void PassengerCancelTicket_Load(object sender, EventArgs e)
        {
            show_data();
        }

        private void PassengerCancelTicket_Shown(object sender, EventArgs e)
        {
            show_data();
        }

        private void show_data()
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    string username = MainLogin.PLUsername; 

                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand = new MySqlDataAdapter("sp_display_cancelPassengerAvailableFlights", mysqlConnection);
                    sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.SelectCommand.Parameters.AddWithValue("pusername", username);

                    DataTable dt = new DataTable();
                    sqlCommand.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelBookedTicketBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    // increment fnoofseat in flight
                    // Decrement Ticket No From Flight Table
                    if (ticketNoTextBox.Text == "") return;
                    int tid = Convert.ToInt32(ticketNoTextBox.Text);

                    mysqlConnection.Open();
                    // generate new invoice
                    // delete record from ticket based on ticket id
                    MySqlCommand sqlCommand2 = new MySqlCommand("sp_delete_passengerTicket", mysqlConnection);
                    sqlCommand2.CommandType = CommandType.StoredProcedure;

                    sqlCommand2.Parameters.AddWithValue("tid", tid);

                    sqlCommand2.ExecuteNonQuery();
                    MessageBox.Show("SUCCESSFULLY CANCELLED TICKET\nORIGNAL AMOUNT: " + ticketPriceTextBox.Text 
                        + "$\nREFUNDED AMOUNT: " + Convert.ToDouble(ticketPriceTextBox.Text) * 0.95f, 
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    show_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketNoTextBox.Text = dataGridView1.CurrentRow.Cells["TTicketNo"].Value.ToString();
            flightIdTextBox.Text = dataGridView1.CurrentRow.Cells["FID"].Value.ToString();
            flightNameTextBox.Text = dataGridView1.CurrentRow.Cells["FName"].Value.ToString();
            ticketPriceTextBox.Text = Convert.ToString(200);
            scityTextBox.Text = dataGridView1.CurrentRow.Cells["FSCity"].Value.ToString();
            scountryTextBox.Text = dataGridView1.CurrentRow.Cells["FSCountry"].Value.ToString();
            dcityTextBox.Text = dataGridView1.CurrentRow.Cells["FDCity"].Value.ToString();
            dcountryTextBox.Text = dataGridView1.CurrentRow.Cells["FDCountry"].Value.ToString();
            departDateTextBox.Text = dataGridView1.CurrentRow.Cells["TDepartTime"].Value.ToString();
        }

        private void clearTicketBtn_Click(object sender, EventArgs e)
        {
            ticketNoTextBox.Text = null;
            flightIdTextBox.Text = null;
            flightNameTextBox.Text = null;
            ticketPriceTextBox.Text = null;
            scityTextBox.Text = null;
            scountryTextBox.Text = null;
            dcityTextBox.Text = null;
            dcountryTextBox.Text = null;
            departDateTextBox.Text = null;

            show_data();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            PassengerUI passengerUI = new PassengerUI();
            passengerUI.MdiParent = MDIForm.ActiveForm;
            passengerUI.WindowState = FormWindowState.Maximized;
            passengerUI.Show();


        }
    }
}
