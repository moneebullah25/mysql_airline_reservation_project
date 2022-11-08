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
    public partial class adminPassengerUserInterface : Form
    {
        public adminPassengerUserInterface()
        {
            InitializeComponent();
        }
        readonly static string stdConnection = ConfigurationManager.ConnectionStrings["dbAppConnection"].ConnectionString;

        private void Form1_Load(object sender, EventArgs e)
        {
            show_data();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUI adminUI = new AdminUI();
            adminUI.MdiParent = MDIForm.ActiveForm;
            adminUI.WindowState = FormWindowState.Maximized;
            adminUI.Show();
        }

        private void clearUserBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = null;
            phoneTextBox.Text = null;
            cnicTextBox.Text = null;
            streetTextBox.Text = null;
            cityTextBox.Text = null;
            countryTextBox.Text = null;
            usernameTextBox.Text = null;
            passwordTextBox.Text = null;
            show_data();
        }

        private void updatePassengerBtn_Click(object sender, EventArgs e)
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

                    show_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void show_data()
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(stdConnection))
                {
                    string username = MainLogin.PLUsername;

                    mysqlConnection.Open();
                    MySqlDataAdapter sqlCommand = new MySqlDataAdapter("sp_display_adminPassenger", mysqlConnection);
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

        private void deletePassengerBtn_Click(object sender, EventArgs e)
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
            nameTextBox.Text = dataGridView1.CurrentRow.Cells["PName"].Value.ToString();
            phoneTextBox.Text = dataGridView1.CurrentRow.Cells["PPhone"].Value.ToString();
            cnicTextBox.Text = dataGridView1.CurrentRow.Cells["PCnic"].Value.ToString();
            streetTextBox.Text = dataGridView1.CurrentRow.Cells["PStreet"].Value.ToString();
            cityTextBox.Text = dataGridView1.CurrentRow.Cells["PCity"].Value.ToString();
            countryTextBox.Text = dataGridView1.CurrentRow.Cells["PCountry"].Value.ToString();
            usernameTextBox.Text = dataGridView1.CurrentRow.Cells["PLUsername"].Value.ToString();
            passwordTextBox.Text = dataGridView1.CurrentRow.Cells["PLPassword"].Value.ToString();

        }

        private void addPassengerBtn_Click(object sender, EventArgs e)
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


                    mysqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand("sp_insert_passenger", mysqlConnection);
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

                    MessageBox.Show("Successfully Added " + usernameTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    show_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
