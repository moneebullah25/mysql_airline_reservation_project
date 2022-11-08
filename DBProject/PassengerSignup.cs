using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PassengerSignup : Form
    {
        public PassengerSignup()
        {
            InitializeComponent();
        }

        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;
        //MySqlConnection mysqlConnection = new MySqlConnection(stdConnection);
        private void saveBtn_Click(object sender, EventArgs e)
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
                    MySqlCommand sqlCommand = new MySqlCommand("sp_insert_passenger", mysqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("pname", (nameTextBox.Text == "") ? null: nameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pphone", phoneTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pcnic", cnicTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pstreet", (streetTextBox.Text == "") ? null : streetTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pcity", (cityTextBox.Text == "") ? null : cityTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("pcountry", (countryTextBox.Text == "") ? null : countryTextBox.Text);
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainLogin mainLogin = new MainLogin();
            mainLogin.MdiParent = MDIForm.ActiveForm;
            mainLogin.WindowState = FormWindowState.Maximized;
            mainLogin.Show();
        }
    }
}
