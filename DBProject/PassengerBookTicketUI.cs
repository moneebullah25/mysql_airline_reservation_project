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
    public partial class PassengerBookTicketUI : Form
    {
        public PassengerBookTicketUI()
        {
            InitializeComponent();
        }

        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;


        private void PassengerBookTicketUI_Load(object sender, EventArgs e)
        {
            show_data();

            departDateTimePicker.Format = DateTimePickerFormat.Custom;
            departDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void PassengerBookTicketUI_Shown(object sender, EventArgs e)
        {
            show_data();
            departDateTimePicker.Format = DateTimePickerFormat.Custom;
            departDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void show_data()
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand = new MySqlDataAdapter("sp_display_passengerAvailableFlights", mysqlConnection);
                    sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    sqlCommand.Fill(dt);
                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetTicketInfoBtn_Click(object sender, EventArgs e)
        {
            flightIdTextBox.Text = null;
            flightNameTextBox.Text = null;
            ticketPriceTextBox.Text = null;
            scityTextBox.Text = null;
            scountryTextBox.Text = null;
            dcityTextBox.Text = null;
            dcountryTextBox.Text = null;

            show_data();
        }

        private void bookTicketBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    // Insert data into Ticket Table
                    string username = MainLogin.PLUsername;
                    int seatno = Convert.ToInt32(seatNoTextBox.Text);
                    Random rnd = new Random();
                    int otp = rnd.Next(1000, 9999);

                    mysqlConnection.Open();
                    MySqlCommand sqlCommand2 = new MySqlCommand("sp_insert_passengerTicket", mysqlConnection);
                    sqlCommand2.CommandType = CommandType.StoredProcedure;

                    sqlCommand2.Parameters.AddWithValue("tprice", Convert.ToInt32(ticketPriceTextBox.Text));
                    sqlCommand2.Parameters.AddWithValue("tseatno", seatno);
                    sqlCommand2.Parameters.AddWithValue("pusername", username);
                    sqlCommand2.Parameters.AddWithValue("tfid", Convert.ToInt32(flightIdTextBox.Text));
                    sqlCommand2.Parameters.AddWithValue("otp", otp);

                    sqlCommand2.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFULLY BOOKED TICKET\nAND YOU HAVE BEEN CHARGED " + ticketPriceTextBox.Text + "$", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flightIdTextBox.Text = dataGridView.CurrentRow.Cells["FID"].Value.ToString();
            flightNameTextBox.Text = dataGridView.CurrentRow.Cells["FName"].Value.ToString();
            ticketPriceTextBox.Text = Convert.ToString(200);
            bscityTextBox.Text = dataGridView.CurrentRow.Cells["FSCity"].Value.ToString();
            bscountryTextBox.Text = dataGridView.CurrentRow.Cells["FSCountry"].Value.ToString();
            bdcityTextBox.Text = dataGridView.CurrentRow.Cells["FDCity"].Value.ToString();
            bdcountryTextBox.Text = dataGridView.CurrentRow.Cells["FDCountry"].Value.ToString();
            departDateTextBox.Text = dataGridView.CurrentRow.Cells["TDepartTime"].Value.ToString();
            seatNoTextBox.Text = dataGridView.CurrentRow.Cells["FNoofSeats"].Value.ToString();

            show_data();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    if (scityTextBox.Text == "" || scityTextBox.Text.Length < 5)
                    {
                        MessageBox.Show("INVALID SOURCE CITY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (scountryTextBox.Text == "" || scountryTextBox.Text.Length < 5)
                    {
                        MessageBox.Show("INVALID SOURCE COUNTRY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (dcityTextBox.Text == "" || dcityTextBox.Text.Length < 5)
                    {
                        MessageBox.Show("INVALID DESINATION CITY ADDRESS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (dcountryTextBox.Text == "" || dcountryTextBox.Text.Length < 5)
                    {
                        MessageBox.Show("INVALID DESTINATION COUNTRY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (departDateTimePicker.Text == "")
                    {
                        MessageBox.Show("INVALID DEPARTURE DATE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand = new MySqlDataAdapter("sp_search_passengerAvailableFlights", mysqlConnection);
                    sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.SelectCommand.Parameters.AddWithValue("scity", scityTextBox.Text);
                    sqlCommand.SelectCommand.Parameters.AddWithValue("scountry", scountryTextBox.Text);
                    sqlCommand.SelectCommand.Parameters.AddWithValue("dcity", dcityTextBox.Text);
                    sqlCommand.SelectCommand.Parameters.AddWithValue("dcountry", dcountryTextBox.Text);
                    sqlCommand.SelectCommand.Parameters.AddWithValue("ddate", Convert.ToDateTime(departDateTimePicker.Text));

                    DataTable dt = new DataTable();
                    sqlCommand.Fill(dt);
                    dataGridView.DataSource = dt;

                    // clear search contents in textNox
                    scityTextBox.Text = "";
                    scountryTextBox.Text = "";
                    dcityTextBox.Text = "";
                    dcountryTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            PassengerUI passengerUI = new PassengerUI();
            passengerUI.MdiParent = MDIForm.ActiveForm;
            passengerUI.WindowState = FormWindowState.Maximized;
            passengerUI.Show();
        }
    }
}
