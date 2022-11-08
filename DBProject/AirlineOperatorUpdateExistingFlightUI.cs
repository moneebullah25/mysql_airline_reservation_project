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
    public partial class AirlineOperatorUpdateExistingFlightUI : Form
    {
        public AirlineOperatorUpdateExistingFlightUI()
        {
            InitializeComponent();
        }


        private void AirlineOperatorUpdateExistingFlightUI_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void AirlineOperatorUpdateExistingFlightUI_Shown(object sender, EventArgs e)
        {
            ReadData();
        }

        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;

        private void ReadData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    string lusername = MainLogin.AOUsername;

                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand = new MySqlDataAdapter("sp_display_airlineOperator_flight", mysqlConnection);
                    sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.SelectCommand.Parameters.AddWithValue("lusername", lusername);

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

                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand = new MySqlDataAdapter("sp_display_passengerAvailableFlights", mysqlConnection);
                    sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.SelectCommand.Parameters.AddWithValue("scity", scityTextBox.Text);
                    sqlCommand.SelectCommand.Parameters.AddWithValue("scountry", scountryTextBox.Text);
                    sqlCommand.SelectCommand.Parameters.AddWithValue("dcity", dcityTextBox.Text);
                    sqlCommand.SelectCommand.Parameters.AddWithValue("dcountry", dcountryTextBox.Text);

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

        private void updateFlightBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    if (flightIdTextBox.Text == "")
                    {
                        MessageBox.Show("INVALID FLIGHT ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (flightNameTextBox.Text == "" || flightNameTextBox.Text.Length < 5)
                    {
                        MessageBox.Show("INVALID FLIGHT NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (noofSeatsTextBox.Text == "")
                    {
                        MessageBox.Show("INVALID NO OF SEATS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (arrivalDateTextBox.Text == "")
                    {
                        MessageBox.Show("INVALID ARRIVAL DATE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (departDateTextBox2.Text == "")
                    {
                        MessageBox.Show("INVALID DEPART DATE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (fscityTextBox.Text == "" || fscityTextBox.Text.Length < 5)
                    {
                        MessageBox.Show("INVALID SOURCE CITY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (fscountryTextBox.Text == "" || fscountryTextBox.Text.Length < 5)
                    {
                        MessageBox.Show("INVALID SOURCE COUNTRY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (fdcityTextBox.Text == "" || fdcityTextBox.Text.Length < 5)
                    {
                        MessageBox.Show("INVALID DESINATION CITY ADDRESS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (fdcountryTextBox.Text == "" || fdcountryTextBox.Text.Length < 5)
                    {
                        MessageBox.Show("INVALID DESTINATION COUNTRY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string username = MainLogin.AOUsername;

                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_update_flight", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("lusername", username);
                    sqlCommand.Parameters.AddWithValue("fID", Convert.ToInt32(flightIdTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("fname", flightNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("NoofSeats", Convert.ToInt32(noofSeatsTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("SCity", fscityTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("SCountry", fscountryTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("DCity", fdcityTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("DCountry", fdcountryTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("DDate", Convert.ToDateTime(departDateTextBox2.Text));
                    sqlCommand.Parameters.AddWithValue("ADate", Convert.ToDateTime(arrivalDateTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("aaid", Convert.ToInt32(airportIDTextBox.Text));

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully Added " + flightIdTextBox.Text + " " + flightNameTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ReadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearFlightBtn_Click(object sender, EventArgs e)
        {
            flightIdTextBox.Text = null;
            flightNameTextBox.Text = null;
            noofSeatsTextBox.Text = null;
            departDateTextBox2.Text = null;
            arrivalDateTextBox.Text = null;
            airportIDTextBox.Text = null;
            fscityTextBox.Text = null;
            fscountryTextBox.Text = null;
            fdcityTextBox.Text = null;
            fdcountryTextBox.Text = null;

            ReadData();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flightIdTextBox.Text = dataGridView.CurrentRow.Cells["FID"].Value.ToString();
            flightNameTextBox.Text = dataGridView.CurrentRow.Cells["FName"].Value.ToString();
            noofSeatsTextBox.Text = dataGridView.CurrentRow.Cells["FNoofSeats"].Value.ToString();
            departDateTextBox2.Text = dataGridView.CurrentRow.Cells["TDepartTime"].Value.ToString();
            arrivalDateTextBox.Text = dataGridView.CurrentRow.Cells["TArrivalTime"].Value.ToString();
            airportIDTextBox.Text = dataGridView.CurrentRow.Cells["AirportID"].Value.ToString();
            fscityTextBox.Text = dataGridView.CurrentRow.Cells["FSCity"].Value.ToString();
            fscountryTextBox.Text = dataGridView.CurrentRow.Cells["FSCountry"].Value.ToString();
            fdcityTextBox.Text = dataGridView.CurrentRow.Cells["FDCity"].Value.ToString();
            fdcountryTextBox.Text = dataGridView.CurrentRow.Cells["FDCountry"].Value.ToString();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            AirlineOperatorUI airlineOperatorUI = new AirlineOperatorUI();
            airlineOperatorUI.MdiParent = MDIForm.ActiveForm;
            airlineOperatorUI.WindowState = FormWindowState.Maximized;
            airlineOperatorUI.Show();
        }
    }
}
