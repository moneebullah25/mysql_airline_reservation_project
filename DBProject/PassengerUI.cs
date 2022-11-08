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
    public partial class PassengerUI : Form
    {
        public PassengerUI()
        {
            InitializeComponent();
        }

        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;

        private void PassengerUI_Shown(object sender, EventArgs e)
        {
            show_passenger_data();
            display_book_ticket_history();
        }

        private void bookTicketBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            PassengerBookTicketUI passengerBookTicketUI = new PassengerBookTicketUI();
            passengerBookTicketUI.MdiParent = MDIForm.ActiveForm;
            passengerBookTicketUI.WindowState = FormWindowState.Maximized;
            passengerBookTicketUI.Show();
        }

        private void cancelTicketBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            PassengerCancelTicket passengerCancelTicket = new PassengerCancelTicket();
            passengerCancelTicket.MdiParent = MDIForm.ActiveForm;
            passengerCancelTicket.WindowState = FormWindowState.Maximized;
            passengerCancelTicket.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainLogin mainLogin = new MainLogin();
            mainLogin.MdiParent = MDIForm.ActiveForm;
            mainLogin.WindowState = FormWindowState.Maximized;
            mainLogin.Show();
        }


        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    if (phoneTextBox.Text == "" || phoneTextBox.Text.Length != 10)
                    {
                        MessageBox.Show("INVALID PHONE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cnicTextBox.Text == "" || cnicTextBox.Text.Length != 13)
                    {
                        MessageBox.Show("INVALID CNIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MySqlCommand sqlCommand = new MySqlCommand("sp_update_passenger", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("pname", (nameTextBox.Text == "") ? null : nameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pphone", phoneTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pcnic", cnicTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pstreet", (streetTextBox.Text == "") ? null : streetTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pcity", (cityTextBox.Text == "") ? null : cityTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pcountry", (countryTextBox.Text == "") ? null : countryTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("lusername", usernameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("lpassword", passwordTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFULLY UPDATED " + usernameTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PassengerUI_Load(object sender, EventArgs e)
        {
            show_passenger_data();
            display_book_ticket_history();
        }

        private void show_passenger_data()
        {
            string username = MainLogin.PLUsername;

            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_get_passenger_info", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add(new MySqlParameter("psname", MySqlDbType.VarChar));
                    sqlCommand.Parameters["psname"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("phone", MySqlDbType.VarChar));
                    sqlCommand.Parameters["phone"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("cnic", MySqlDbType.VarChar));
                    sqlCommand.Parameters["cnic"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("street", MySqlDbType.VarChar));
                    sqlCommand.Parameters["street"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("city", MySqlDbType.VarChar));
                    sqlCommand.Parameters["city"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.Add(new MySqlParameter("country", MySqlDbType.VarChar));
                    sqlCommand.Parameters["country"].Direction = ParameterDirection.Output;

                    sqlCommand.Parameters.AddWithValue("lusername", username);

                    sqlCommand.Parameters.Add(new MySqlParameter("lpassword", MySqlDbType.VarChar));
                    sqlCommand.Parameters["lpassword"].Direction = ParameterDirection.Output;

                    sqlCommand.ExecuteNonQuery();

                    string name = sqlCommand.Parameters["psname"].Value.ToString() == "" ? null : sqlCommand.Parameters["psname"].Value.ToString();
                    nameTextBox.Text = name;
                    phoneTextBox.Text = sqlCommand.Parameters["phone"].Value.ToString() == "" ? null : sqlCommand.Parameters["phone"].Value.ToString();
                    cnicTextBox.Text = sqlCommand.Parameters["cnic"].Value.ToString() == "" ? null : sqlCommand.Parameters["cnic"].Value.ToString();
                    streetTextBox.Text = sqlCommand.Parameters["street"].Value.ToString() == "" ? null : sqlCommand.Parameters["street"].Value.ToString();
                    cityTextBox.Text = sqlCommand.Parameters["city"].Value.ToString() == "" ? null : sqlCommand.Parameters["city"].Value.ToString();
                    countryTextBox.Text = sqlCommand.Parameters["country"].Value.ToString() == "" ? null : sqlCommand.Parameters["country"].Value.ToString();
                    usernameTextBox.Text = username;
                    passwordTextBox.Text = sqlCommand.Parameters["lpassword"].Value.ToString() == "" ? null : sqlCommand.Parameters["lpassword"].Value.ToString();
                    confirmPasswordTextBox.Text = passwordTextBox.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetInfoBtn_Click(object sender, EventArgs e)
        {
            show_passenger_data();
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_delete_passenger", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("cnic", cnicTextBox.Text);
                
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFULLY DELETED ACCOUNT " + usernameTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void refreshTicketBtn_Click(object sender, EventArgs e)
        {
            display_book_ticket_history();
        }

        private void display_book_ticket_history()
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand = new MySqlDataAdapter("sp_display_passengerBookedTicket", mysqlConnection);
                    sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.SelectCommand.Parameters.AddWithValue("cnic", cnicTextBox.Text);

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
    }
}
