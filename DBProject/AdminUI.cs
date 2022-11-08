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
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void passengerLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPassengerUserInterface adminPassengerUI = new adminPassengerUserInterface();
            adminPassengerUI.MdiParent = MDIForm.ActiveForm;
            adminPassengerUI.WindowState = FormWindowState.Maximized;
            adminPassengerUI.Show();
        }

        private void airlineOperatorLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminAirlineOperatorUI adminAirlineOperatorUI = new AdminAirlineOperatorUI();
            adminAirlineOperatorUI.MdiParent = MDIForm.ActiveForm;
            adminAirlineOperatorUI.WindowState = FormWindowState.Maximized;
            adminAirlineOperatorUI.Show();
        }

        private void airportLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminAirportUI adminAirportUI = new AdminAirportUI();
            adminAirportUI.MdiParent = MDIForm.ActiveForm;
            adminAirportUI.WindowState = FormWindowState.Maximized;
            adminAirportUI.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainLogin mainLogin = new MainLogin();
            mainLogin.MdiParent = MDIForm.ActiveForm;
            mainLogin.WindowState = FormWindowState.Maximized;
            mainLogin.Show();
        }

        private void passengerLabel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            adminPassengerUserInterface adminPassengerUserInterface = new adminPassengerUserInterface();
            adminPassengerUserInterface.MdiParent = MDIForm.ActiveForm;
            adminPassengerUserInterface.WindowState = FormWindowState.Maximized;
            adminPassengerUserInterface.Show();
        }
    }
}
