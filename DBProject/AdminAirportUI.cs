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
    public partial class AdminAirportUI : Form
    {
        public AdminAirportUI()
        {
            InitializeComponent();
        }

        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;


        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUI adminUI = new AdminUI();
            adminUI.MdiParent = MDIForm.ActiveForm;
            adminUI.WindowState = FormWindowState.Maximized;
            adminUI.Show();
        }

        private void AdminAirportUI_Load(object sender, EventArgs e)
        {
            show_data();
        }

        private void show_data()
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand = new MySqlDataAdapter("sp_display_admin_airport", mysqlConnection);
                    sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
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

        private void addAirportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_insert_adminAirport", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    if (airportIdTextBox.Text == "")
                    {
                        MessageBox.Show("INVALID AIRPORT ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (noofFlightsTextBox.Text == "")
                    {
                        MessageBox.Show("INVALID NO OF FLIGHTS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    sqlCommand.Parameters.AddWithValue("id", Convert.ToInt32(airportIdTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("name", airportNameTextBox.Text == ""? null: airportNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("noofflight", noofFlightsTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFULLY ADDED ID " + airportIdTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            airportNameTextBox.Text = dataGridView1.CurrentRow.Cells["AName"].Value.ToString();
            airportIdTextBox.Text = dataGridView1.CurrentRow.Cells["AID"].Value.ToString();
            noofFlightsTextBox.Text = dataGridView1.CurrentRow.Cells["ANoofFlights"].Value.ToString();
        }

        private void updateAirportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    if (airportIdTextBox.Text == "") return;
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_update_adminAirport", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    if (airportIdTextBox.Text == "")
                    {
                        MessageBox.Show("INVALID AIRPORT ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (noofFlightsTextBox.Text == "")
                    {
                        MessageBox.Show("INVALID NO OF FLIGHTS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    sqlCommand.Parameters.AddWithValue("id", Convert.ToInt32(airportIdTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("name", airportNameTextBox.Text == "" ? null : airportNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("noofflight", noofFlightsTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFULLY UPDATED ID " + airportIdTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    show_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteAirportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    if (airportIdTextBox.Text == "") return;
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_delete_adminAirport", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("id", Convert.ToInt32(airportIdTextBox.Text));

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFULLY DELETED ID " + airportIdTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    show_data();
                    // Clear cells
                    airportNameTextBox.Text ="";
                    airportIdTextBox.Text = "";
                    noofFlightsTextBox.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearAirportBtn_Click(object sender, EventArgs e)
        {
            airportNameTextBox.Text = "";
            airportIdTextBox.Text = "";
            noofFlightsTextBox.Text = "";
        }
    }
}
