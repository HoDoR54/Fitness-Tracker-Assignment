using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness_Tracker.Utils;

namespace Fitness_Tracker.Forms
{
    public partial class RegistrationForm : Form
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();
        private int _attemptCount = 0;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void toLogInLink_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        public bool ValidateRegisPw(string password)
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

        private void signUpButton_Click(object sender, EventArgs e)
        {
            _attemptCount++;
            if (_attemptCount >= 5)
            {
                MessageBox.Show("You are making too many attempts.", "Too many attempts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            if (string.IsNullOrEmpty(usernameTextBox.Text.Trim()))
            {
                MessageBox.Show("A username is required.", "Empty username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                usernameTextBox.Clear();
                usernameTextBox.Focus();
            }
            else if (usernameTextBox.Text.Contains(" "))
            {
                MessageBox.Show("A username must not contain any space.", "Empty username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                usernameTextBox.Clear();
                usernameTextBox.Focus();
            }
            else if (usernameTextBox.Text.Any((ch) => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Username must only contain letters and numbers.", "Invalid username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                usernameTextBox.Clear();
                usernameTextBox.Focus();
            }
            else if (_dbHelper.CheckAccountExistence(usernameTextBox.Text.Trim()))
            {
                MessageBox.Show("A user with this username already exists.", "Duplicated username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                usernameTextBox.Clear();
                usernameTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(fullNameTextBox.Text.Trim()))
            {
                MessageBox.Show("A name is required", "Empty name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                fullNameTextBox.Clear();
                fullNameTextBox.Focus();
            }
            else if (!maleRadio.Checked && !femaleRadio.Checked)
            {
                MessageBox.Show("You must choose a gender for more accuracy.", "Empty gender choice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(passwordTextBox.Text.Trim()))
            {
                MessageBox.Show("A password is required", "Empty password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
            else if (!ValidateRegisPw(passwordTextBox.Text.Trim()))
            {
                passwordTextBox.Focus();
                passwordTextBox.Clear();
                return;
            }
            else if (DOB.Value > DateTime.Today.AddYears(-15))
            {
                MessageBox.Show("You must be at least 15 years old to register.", "Invalid date of birth", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                DOB.Focus();
            }
            else
            {
                bool gender = femaleRadio.Checked;

                User newUser = new User(
                    username: usernameTextBox.Text.Trim(),
                    name: fullNameTextBox.Text.Trim(),
                    dateOfBirth: DOB.Value,
                    heightInCm: numHeight.Value,
                    currentWeight: numCurrentWeight.Value,
                    weightGoal: numGoalWeight.Value,
                    password: passwordTextBox.Text.Trim(),
                    gender: gender ? "Female" : "Male",
                    dailyCalorie: 0
                );
                _dbHelper.InsertUser(newUser);

                MessageBox.Show("Account created successfully.", "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeForm mainForm = new HomeForm(newUser);
                mainForm.Show();
                this.Hide();
            }

        }
    }
}
