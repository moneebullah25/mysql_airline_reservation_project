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
    public partial class AirlineOperatorAddFlight : Form
    {
        public AirlineOperatorAddFlight()
        {
            InitializeComponent();
        }


        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;

        private void saveBtn_Click(object sender, EventArgs e)
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
                    if (arrivalDateTimePicker.Value.ToString() == "")
                    {
                        MessageBox.Show("INVALID ARRIVAL DATE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (departDateTimePicker.Value.ToString() == "")
                    {
                        MessageBox.Show("INVALID DEPART DATE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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
                    if (airportComboBox.Text == "")
                    {
                        MessageBox.Show("INVALID AIRPORT ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string username = MainLogin.AOUsername;

                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_insert_flight", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("lusername", username);
                    sqlCommand.Parameters.AddWithValue("fID", Convert.ToInt32(flightIdTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("fname", flightNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("NoofSeats", Convert.ToInt32(noofSeatsTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("SCity", scityTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("SCountry", scountryTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("DCity", dcityTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("DCountry", dcountryTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("DDate", Convert.ToDateTime(departDateTimePicker.Value.ToString()));
                    sqlCommand.Parameters.AddWithValue("ADate", Convert.ToDateTime(arrivalDateTimePicker.Value.ToString()));
                    sqlCommand.Parameters.AddWithValue("aaid", Convert.ToInt32(airportComboBox.Text));

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully Added " + flightIdTextBox.Text + " " + flightNameTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    AirlineOperatorUI airlineOperatorUI = new AirlineOperatorUI();
                    airlineOperatorUI.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AirlineOperatorUI airlineOperatorUI = new AirlineOperatorUI();
            airlineOperatorUI.Show();
        }

        private void AirlineOperatorAddFlight_Load(object sender, EventArgs e)
        {
            departDateTimePicker.Format = DateTimePickerFormat.Custom;
            departDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";

            arrivalDateTimePicker.Format = DateTimePickerFormat.Custom;
            arrivalDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";

            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_get_airportID", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    MySqlDataReader dr = sqlCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        airportComboBox.Items.Add(dr[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
