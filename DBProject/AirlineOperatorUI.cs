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
    public partial class AirlineOperatorUI : Form
    {
        public AirlineOperatorUI()
        {
            InitializeComponent();
        }

        private void addFlightBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AirlineOperatorAddFlight airlineOperatorAddFlight = new AirlineOperatorAddFlight();
            airlineOperatorAddFlight.MdiParent = MDIForm.ActiveForm;
            airlineOperatorAddFlight.WindowState = FormWindowState.Maximized;
            airlineOperatorAddFlight.Show();
        }

        private void updateExistingFlightBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AirlineOperatorUpdateExistingFlightUI updateExistingFlightUI = new AirlineOperatorUpdateExistingFlightUI();
            updateExistingFlightUI.MdiParent = MDIForm.ActiveForm;
            updateExistingFlightUI.WindowState = FormWindowState.Maximized;
            updateExistingFlightUI.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainLogin mainLogin = new MainLogin();
            mainLogin.MdiParent = MDIForm.ActiveForm;
            mainLogin.WindowState = FormWindowState.Maximized;
            mainLogin.Show();
        }
        
        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;

        private void AirlineOperatorUI_Shown(object sender, EventArgs e)
        {
            display_airline_data();
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
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


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetInfoBtn_Click(object sender, EventArgs e)
        {
            display_airline_data();
        }

        private void display_airline_data()
        {
            string username = MainLogin.AOUsername;

            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_get_airlineOperator_info", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add(new MySqlParameter("MC", MySqlDbType.VarChar));
                    sqlCommand.Parameters["MC"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("LegalName", MySqlDbType.VarChar));
                    sqlCommand.Parameters["LegalName"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("DBAName", MySqlDbType.VarChar));
                    sqlCommand.Parameters["DBAName"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("Phone", MySqlDbType.VarChar));
                    sqlCommand.Parameters["Phone"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("Street", MySqlDbType.VarChar));
                    sqlCommand.Parameters["Street"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("City", MySqlDbType.VarChar));
                    sqlCommand.Parameters["City"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("Country", MySqlDbType.VarChar));
                    sqlCommand.Parameters["Country"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.AddWithValue("lusername", username);

                    sqlCommand.Parameters.Add(new MySqlParameter("lpassword", MySqlDbType.VarChar));
                    sqlCommand.Parameters["lpassword"].Direction = ParameterDirection.Output;

                    sqlCommand.ExecuteNonQuery();

                    legalNameTextBox.Text = sqlCommand.Parameters["LegalName"].Value.ToString() == "" ? null : sqlCommand.Parameters["LegalName"].Value.ToString();
                    mcNoTextBox.Text = sqlCommand.Parameters["MC"].Value.ToString() == "" ? null : sqlCommand.Parameters["MC"].Value.ToString();
                    dbaNameTextBox.Text = sqlCommand.Parameters["DBAName"].Value.ToString() == "" ? null : sqlCommand.Parameters["DBAName"].Value.ToString();
                    phoneTextBox.Text = sqlCommand.Parameters["Phone"].Value.ToString() == "" ? null : sqlCommand.Parameters["Phone"].Value.ToString();
                    streetTextBox.Text = sqlCommand.Parameters["Street"].Value.ToString() == "" ? null : sqlCommand.Parameters["Street"].Value.ToString();
                    cityTextBox.Text = sqlCommand.Parameters["City"].Value.ToString() == "" ? null : sqlCommand.Parameters["City"].Value.ToString();
                    countryTextBox.Text = sqlCommand.Parameters["Country"].Value.ToString() == "" ? null : sqlCommand.Parameters["Country"].Value.ToString();
                    usernameTextBox.Text = username;
                    passwordTextBox.Text = sqlCommand.Parameters["lpassword"].Value.ToString() == "" ? null : sqlCommand.Parameters["lpassword"].Value.ToString();
                    confirmPasswordTextBox.Text = passwordTextBox.Text;
                    mysqlConnection.Close();
                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand2 = new MySqlDataAdapter("sp_display_airlineOperator_flight", mysqlConnection);
                    sqlCommand2.SelectCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand2.SelectCommand.Parameters.AddWithValue("lusername", usernameTextBox.Text);

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

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    MessageBox.Show("YOU CAN'T DELETE ACCOUNT!\nBECAUSE YOU HAVE ALREADY ADDED FLIGHTS" + mcNoTextBox.Text, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_delete_airlineOperator", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("mcNo", mcNoTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("DELETE ACCOUNT FOR MC " + mcNoTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    MainLogin mainLogin = new MainLogin();
                    mainLogin.MdiParent = MDIForm.ActiveForm;
                    mainLogin.WindowState = FormWindowState.Maximized;
                    mainLogin.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AirlineOperatorUI_Load(object sender, EventArgs e)
        {
            display_airline_data();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                confirmPasswordTextBox.UseSystemPasswordChar = false;
            }

            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                confirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void deleteFlightBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AirlineOperatorDeleteFlight airlineOperatorDeleteFlight = new AirlineOperatorDeleteFlight();
            airlineOperatorDeleteFlight.MdiParent = MDIForm.ActiveForm;
            airlineOperatorDeleteFlight.WindowState = FormWindowState.Maximized;
            airlineOperatorDeleteFlight.Show();
        }
    }
}
