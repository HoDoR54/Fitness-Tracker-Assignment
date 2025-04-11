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
    public partial class LoginForm : Form
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();
        private int _attemptCount = 0;

        public LoginForm()
        {
            InitializeComponent();        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toRegisLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            _attemptCount++;
            if (_attemptCount >= 3)
            {
                MessageBox.Show("You are making too many attempts.", "Too many attempts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else if(string.IsNullOrEmpty(usernameTextBox.Text.Trim()))
            {
                MessageBox.Show("A username is required.", "Empty username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                usernameTextBox.Clear();
                usernameTextBox.Focus();
            }
            else if(string.IsNullOrEmpty((string)passwordTextBox.Text.Trim()))
            {
                MessageBox.Show("A password is required.", "Empty password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
            else if (!_dbHelper.CheckAccountExistence(usernameTextBox.Text.Trim()))
            {
                MessageBox.Show("User does not exist in the database. try agian.", "Non-existant user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                passwordTextBox.Clear();
                usernameTextBox.Clear();
                usernameTextBox.Focus();
            }
            else if (!_dbHelper.CheckPassword(usernameTextBox.Text.Trim() ,passwordTextBox.Text.Trim()))
            {
                MessageBox.Show("Incorrect password. Try again", "Incorrect password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Successfully logged in.", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeForm frmMain = new HomeForm(_dbHelper.GetUserByUsername(usernameTextBox.Text.Trim()));
                frmMain.Show();
                this.Hide();
            }
        }
    }
}
