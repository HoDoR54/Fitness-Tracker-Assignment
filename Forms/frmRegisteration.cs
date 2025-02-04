using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness_Tracker.Models;
using Fitness_Tracker.Utils;

namespace Fitness_Tracker.Forms
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegisteration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        public static bool ValidateRegisPw(string password)
        {
            bool isValid = true;
            List<string> alertMessages = new List<string>();

            if (password.Length < 12)
            {
                alertMessages.Add("A password should be no shorter than 12 characters.");
                isValid = false;
            }
            if (!password.Any(char.IsUpper))
            {
                alertMessages.Add("Password must contain at least one uppercase letter.");
                isValid = false;
            }
            if (!password.Any(char.IsLower))
            {
                alertMessages.Add("Password must contain at least one lowercase letter.");
                isValid = false;
            }
            if (!password.Any(char.IsDigit))
            {
                alertMessages.Add("Password must contain at least one number.");
                isValid = false;
            }
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                alertMessages.Add("Password must contain at least one special character (e.g., !@#$%^&*).");
                isValid = false;
            }
            if (password.Contains(" "))
            {
                alertMessages.Add("Password must not contain spaces.");
                isValid = false;
            }
            if (!isValid)
            {
                string message = string.Join("\n", alertMessages);
                MessageBox.Show(message, "Invalid password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return isValid;
        }


        int attemptCount = 0;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            attemptCount++;
            if (attemptCount >= 5)
            {
                MessageBox.Show("You are making too many attempts.", "Too many attempts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else if (string.IsNullOrEmpty(txtUsername.Text.Trim()) || txtUsername.Text.Contains(" "))
            {
                MessageBox.Show("A username is required and must not contain space.", "Empty username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                txtUsername.Clear();
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("A name is required", "Empty name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                txtName.Clear();
                txtName.Focus();
            }
            else if (DateTime.Now.AddYears(-18) < dtpDob.Value)
            {
                MessageBox.Show("You must be at least 18 years old.", "Invalid age", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                dtpDob.Focus();
            }
            else if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("You must choose a gender for more accuracy.", "Empty gender choice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("A password is required", "Empty password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                txtPassword.Clear();
                txtPassword.Focus();
            }
            else if (!ValidateRegisPw(txtPassword.Text.Trim()))
            {
                txtPassword.Focus();
                txtPassword.Clear();
                return;
            }
            else
            {
                bool gender = rdoFemale.Checked;

                clsUser newUser = new clsUser(
                    username: txtUsername.Text.Trim(),
                    name: txtName.Text.Trim(),
                    dateOfBirth: dtpDob.Value,
                    heightInCm: numHeight.Value,
                    currentWeight: numCurrentWeight.Value,
                    weightGoal: numGoalWeight.Value,
                    password: txtPassword.Text.Trim(),
                    gender: gender ? "Female" : "Male"
                );
                DatabaseHelper databaseHelper = new DatabaseHelper();
                databaseHelper.InsertUser(newUser);

                MessageBox.Show("Account created successfully.", "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain frmMain = new frmMain(newUser);
                frmMain.Show();
                this.Hide();
            }

        }
    }
}
