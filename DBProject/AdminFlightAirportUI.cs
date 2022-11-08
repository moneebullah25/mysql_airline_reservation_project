using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AdminFlightAirportUI : Form
    {
        public AdminFlightAirportUI()
        {
            InitializeComponent();
        }

        private void AdminFlightAirportUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUI adminUI = new AdminUI();
            adminUI.Show();
        }
    }
}
