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
    public partial class AirlineOperatorDeleteFlight : Form
    {
        public AirlineOperatorDeleteFlight()
        {
            InitializeComponent();
        }

        private void AirlineOperatorDeleteFlight_Load(object sender, EventArgs e)
        {
            show_data();
        }

        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;

        private void deleteFlightBtn_Click(object sender, EventArgs e)
        {
            try
            { 
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_delete_flight", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("lusername", MainLogin.AOUsername);
                    sqlCommand.Parameters.AddWithValue("fID", flightIdTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    if (dataGridView1.Rows.Count > 0)
                        MessageBox.Show("SUCCESSFULLY DELETED FLIGHT " + flightIdTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("THERE MIGHT BE SOME PASSENGERS WHO BOOK THIS FLIGHT ALREADY\nSO YOU CAN'T DELETE THIS FLIGHT UNLESS THEY CANCEL THEIR TICKET THEMSELEVES" + flightIdTextBox.Text,
                            "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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
            scityTextBox.Text = null;
            scountryTextBox.Text = null;
            dcityTextBox.Text = null;
            dcountryTextBox.Text = null;
            departDateTextBox.Text = null;
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            AirlineOperatorUI mainLogin = new AirlineOperatorUI();
            mainLogin.MdiParent = MDIForm.ActiveForm;
            mainLogin.WindowState = FormWindowState.Maximized;
            mainLogin.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flightIdTextBox.Text = dataGridView1.CurrentRow.Cells["FID"].Value.ToString();
            flightNameTextBox.Text = dataGridView1.CurrentRow.Cells["FName"].Value.ToString();
            scityTextBox.Text = dataGridView1.CurrentRow.Cells["FSCity"].Value.ToString();
            scountryTextBox.Text = dataGridView1.CurrentRow.Cells["FSCountry"].Value.ToString();
            dcityTextBox.Text = dataGridView1.CurrentRow.Cells["FDCity"].Value.ToString();
            dcountryTextBox.Text = dataGridView1.CurrentRow.Cells["FDCountry"].Value.ToString();
            departDateTextBox.Text = dataGridView1.CurrentRow.Cells["TDepartTime"].Value.ToString();
           
            show_data();
        }

        private void show_data()
        {
            string username = MainLogin.AOUsername;

            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    MySqlDataAdapter sqlCommand2 = new MySqlDataAdapter("sp_display_airlineOperator_flight", mysqlConnection);
                    sqlCommand2.SelectCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand2.SelectCommand.Parameters.AddWithValue("lusername", username);

                    DataTable dt = new DataTable();
                    sqlCommand2.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AirlineOperatorDeleteFlight_Shown(object sender, EventArgs e)
        {
            show_data();
        }
    }
}
