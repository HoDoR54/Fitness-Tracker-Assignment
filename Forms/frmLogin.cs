using Fitness_Tracker.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker.Forms
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
            this.Hide();
        }

        int attemptCount = 0;
        DatabaseHelper databaseHelper = new DatabaseHelper();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            attemptCount++;
            if (attemptCount >= 3)
            {
                MessageBox.Show("You are making too many attempts.", "Too many attempts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else if(string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("A username is required.", "Empty username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                txtUsername.Clear();
                txtUsername.Focus();
            }
            else if(string.IsNullOrEmpty((string)txtPassword.Text.Trim()))
            {
                MessageBox.Show("A password is required.", "Empty password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                txtPassword.Clear();
                txtPassword.Focus();
            }
            else if (!databaseHelper.CheckAccountExistence(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                MessageBox.Show("User does not exist in the database. try agian.", "Non-existant user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Successfully logged in.", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain frmMain = new frmMain(databaseHelper.GetUserByUsername(txtUsername.Text.Trim()));
                frmMain.Show();
                this.Hide();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
