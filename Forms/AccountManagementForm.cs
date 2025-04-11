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
    public partial class AccountManagementForm : Form
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();
        private User _currentUser;
        public AccountManagementForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }
        private void AccountManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void deleteAccButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete your account?",
                                             "Confirm Deletion",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _dbHelper.DeleteAccount(_currentUser.GetUsername());
                MessageBox.Show($"Account '{_currentUser.GetUsername()}' has been successfully deleted.", "Account deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();
            }
        }

        private void AccountManagementForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = _currentUser.GetName();
            usernameLabel.Text = $"Username: {_currentUser.GetUsername()}";
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            HomeForm existingMainForm = Application.OpenForms.OfType<HomeForm>().FirstOrDefault();
            existingMainForm.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void anotherAccButton_Click(object sender, EventArgs e)
        {
            HomeForm existingMainForm = Application.OpenForms.OfType<HomeForm>().FirstOrDefault();
            existingMainForm.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void newAccButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
