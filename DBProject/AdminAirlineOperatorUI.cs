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
    public partial class AdminAirlineOperatorUI : Form
    {
        public AdminAirlineOperatorUI()
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

        private void AdminAirlineOperatorUI_Load(object sender, EventArgs e)
        {
            display_airline_data();
        }

        private void addAirlineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    if (mcNoTextBox.Text == "")
                    {
                        MessageBox.Show("ENTER MC NUMBER", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (legalNameTextBox.Text == "")
                    {
                        MessageBox.Show("ENTER LEGAL NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (streetTextBox.Text == "")
                    {
                        MessageBox.Show("ENTER STREET NO AND STEET NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cityTextBox.Text == "")
                    {
                        MessageBox.Show("ENTER CITY, STATE AND ZIP CODE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (countryTextBox.Text == "")
                    {
                        MessageBox.Show("ENTER COUNTRY NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (phoneTextBox.Text == "" || phoneTextBox.Text.Length != 10)
                    {
                        MessageBox.Show("INVALID PHONE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (usernameTextBox.Text == "")
                    {
                        MessageBox.Show("INVALID USERNAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (passwordTextBox.Text == "" || passwordTextBox.Text.Length < 8)
                    {
                        MessageBox.Show("INVALID PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                    {
                        MessageBox.Show("PASSWORD DONT MATCH", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_insert_airlineOperator", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("mcNo", mcNoTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("legalName", legalNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("dbaName", dbaNameTextBox.Text == "" ? null : dbaNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("phone", phoneTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("street", streetTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("city", cityTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("country", countryTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("lusername", usernameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("lpassword", passwordTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully Added " + usernameTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    display_airline_data();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dbaNameTextBox.Text = dataGridView1.CurrentRow.Cells["AODBAName"].Value.ToString().Length == 0 ? null :
                dataGridView1.CurrentRow.Cells["AODBAName"].Value.ToString();
            legalNameTextBox.Text = dataGridView1.CurrentRow.Cells["AOLegalName"].Value.ToString();
            mcNoTextBox.Text = dataGridView1.CurrentRow.Cells["AOMC"].Value.ToString();
            phoneTextBox.Text = dataGridView1.CurrentRow.Cells["AOPhone"].Value.ToString();
            streetTextBox.Text = dataGridView1.CurrentRow.Cells["AOStreet"].Value.ToString();
            cityTextBox.Text = dataGridView1.CurrentRow.Cells["AOCity"].Value.ToString();
            countryTextBox.Text = dataGridView1.CurrentRow.Cells["AOCountry"].Value.ToString();
            usernameTextBox.Text = dataGridView1.CurrentRow.Cells["AOUsername"].Value.ToString();
            passwordTextBox.Text = dataGridView1.CurrentRow.Cells["AOPassword"].Value.ToString();
            confirmPasswordTextBox.Text = passwordTextBox.Text;
        }

        private void AdminAirlineOperatorUI_Shown(object sender, EventArgs e)
        {
            display_airline_data();
        }

        void display_airline_data()
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    string username = MainLogin.AOUsername;

                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand = new MySqlDataAdapter("sp_display_adminAirline", mysqlConnection);
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

        private void updateAirlineBtn_Click(object sender, EventArgs e)
        {
            if (mcNoTextBox.Text == "") return;
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {

                    if (legalNameTextBox.Text == "")
                    {
                        MessageBox.Show("LEGAL NAME CANT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (streetTextBox.Text == "")
                    {
                        MessageBox.Show("ENTER STREET NO AND STEET NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cityTextBox.Text == "")
                    {
                        MessageBox.Show("ENTER CITY, STATE AND ZIP CODE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (countryTextBox.Text == "")
                    {
                        MessageBox.Show("ENTER COUNTRY NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (phoneTextBox.Text == "" || phoneTextBox.Text.Length != 10)
                    {
                        MessageBox.Show("INVALID PHONE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                    {
                        MessageBox.Show("PASSWORD DOESNOT MATCH", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_update_airlineOperator", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("mcNo", mcNoTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("legalName", legalNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("dbaName", dbaNameTextBox.Text == "" ? null : dbaNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("phone", phoneTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("street", streetTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("city", cityTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("country", countryTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("lusername", usernameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("lpassword", passwordTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully Updated MC " + mcNoTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    display_airline_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteAirlineBtn_Click(object sender, EventArgs e)
        {
            if (mcNoTextBox.Text == "")
            {
                MessageBox.Show("PLEASE SELECT DATA FROM TABLE BY DOUBLE CLICKING ON IT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_delete_airlineOperator", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("mcNo", mcNoTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("DELETE ACCOUNT FOR MC " + mcNoTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    display_airline_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearAirlineBtn_Click(object sender, EventArgs e)
        {
            // Clear Cell Contents
            dbaNameTextBox.Text = null;
            legalNameTextBox.Text = null;
            phoneTextBox.Text = null;
            streetTextBox.Text = null;
            cityTextBox.Text = null;
            countryTextBox.Text = null;
            usernameTextBox.Text = null;
            passwordTextBox.Text = null;
            confirmPasswordTextBox.Text = null;
            mcNoTextBox.Text = null;
            display_airline_data();
        }

    }
}
