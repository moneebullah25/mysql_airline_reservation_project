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
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            MainLogin mainLogin = new MainLogin();
            mainLogin.MdiParent = MDIForm.ActiveForm;
            mainLogin.WindowState = FormWindowState.Maximized;
            mainLogin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDIForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIForm_Shown(object sender, EventArgs e)
        {
            MainLogin mainLogin = new MainLogin();
            mainLogin.MdiParent = MDIForm.ActiveForm;
            mainLogin.WindowState = FormWindowState.Maximized;
            mainLogin.Show();
        }
    }
}
