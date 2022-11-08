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
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        static public string AOUsername = "";
        static public string PLUsername = "";

        private void signupPassengerLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            PassengerSignup psu = new PassengerSignup();
            psu.MdiParent = MDIForm.ActiveForm;
            psu.WindowState = FormWindowState.Maximized;
            psu.Show();
        }

        private void signupAirlineOperatorLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            AirlineOperatorSignup aosu = new AirlineOperatorSignup();
            aosu.MdiParent = MDIForm.ActiveForm;
            aosu.WindowState = FormWindowState.Maximized;
            aosu.Show();
        }


        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginAsComboBox.Text == "")
            {
                MessageBox.Show("INVALID LOGIN OPTION SELECTED", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (loginAsComboBox.SelectedItem.ToString() == "Administrator" &&
                usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                this.Close();
                AdminUI adminUI = new AdminUI();
                adminUI.MdiParent = MDIForm.ActiveForm;
                adminUI.WindowState = FormWindowState.Maximized;
                adminUI.Show();
            }
            else if (loginAsComboBox.SelectedItem.ToString() == "Passenger")
            {
                try
                {
                    using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                    {
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

                        mysqlConnection.Open();
                        MySqlCommand sqlCommand = new MySqlCommand("sp_search_passenger", mysqlConnection);
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        int access_allowed = 0;
                        sqlCommand.Parameters.AddWithValue("lusername", usernameTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("lpassword", passwordTextBox.Text);
                        sqlCommand.Parameters.Add(new MySqlParameter("?access", MySqlDbType.Int32));
                        sqlCommand.Parameters["?access"].Direction = ParameterDirection.Output;
                        int x = sqlCommand.ExecuteNonQuery();

                        access_allowed = (int)sqlCommand.Parameters["?access"].Value;
                        if (x != 0 && access_allowed == 0) { 
                            MessageBox.Show("RECORD NOT FOUND FOR " + usernameTextBox.Text + " PLEASE SIGNUP", "INVALID CREDENTIALS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        PLUsername = usernameTextBox.Text;

                        this.Close();
                        PassengerUI passengerUI = new PassengerUI();
                        passengerUI.MdiParent = MDIForm.ActiveForm;
                        passengerUI.WindowState = FormWindowState.Maximized;
                        passengerUI.Show();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (loginAsComboBox.SelectedItem.ToString() == "Airline Operator")
            {
                try
                {
                    using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                    {
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

                        mysqlConnection.Open();
                        MySqlCommand sqlCommand = new MySqlCommand("sp_search_airlineOperator", mysqlConnection);
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        int access_allowed = 0;
                        sqlCommand.Parameters.AddWithValue("lusername", usernameTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("lpassword", passwordTextBox.Text);
                        sqlCommand.Parameters.Add(new MySqlParameter("?access", MySqlDbType.Int32));
                        sqlCommand.Parameters["?access"].Direction = ParameterDirection.Output;
                        sqlCommand.ExecuteNonQuery();

                        access_allowed = (int)sqlCommand.Parameters["?access"].Value;
                        if (access_allowed == 0)
                        {
                            MessageBox.Show("RECORD NOT FOUND FOR " + usernameTextBox.Text + " PLEASE SIGNUP", "INVALID CREDENTIALS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        AOUsername = usernameTextBox.Text;

                        this.Close();
                        AirlineOperatorUI airlineOperatorUI = new AirlineOperatorUI();
                        airlineOperatorUI.MdiParent = MDIForm.ActiveForm;
                        airlineOperatorUI.WindowState = FormWindowState.Maximized;
                        airlineOperatorUI.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("PLEASE SELECT THE CORRECT OPTION", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked) passwordTextBox.UseSystemPasswordChar = false;
            else passwordTextBox.UseSystemPasswordChar = true;
        }
    }
}
