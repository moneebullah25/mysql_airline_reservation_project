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
    public partial class AirlineOperatorSignup : Form
    {
        public AirlineOperatorSignup()
        {
            InitializeComponent();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainLogin mainLogin = new MainLogin();
            mainLogin.MdiParent = MDIForm.ActiveForm;
            mainLogin.WindowState = FormWindowState.Maximized;
            mainLogin.Show();
        }

        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;

        private void saveBtn_Click(object sender, EventArgs e)
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
                    sqlCommand.Parameters.AddWithValue("dbaName", dbaNameTextBox.Text==""?null: dbaNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("phone", phoneTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("street", streetTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("city", cityTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("country", countryTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("lusername", usernameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("lpassword", passwordTextBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully Added " + usernameTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
    }
}
