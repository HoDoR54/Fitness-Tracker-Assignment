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
        private void frmAccountMgmt_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete your account?",
                                             "Confirm Deletion",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _dbHelper.DeleteAccount(_currentUser.Username);
                MessageBox.Show($"Account '{_currentUser.Username}' has been successfully deleted.", "Account deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();
            }
        }

        private void frmAccountMgmt_Load(object sender, EventArgs e)
        {
            nameLabel.Text = _currentUser.Name;
            usernameLabel.Text = $"Username: {_currentUser.Username}";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            HomeForm existingMainForm = Application.OpenForms.OfType<HomeForm>().FirstOrDefault();
            existingMainForm.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void btnAnthAcc_Click(object sender, EventArgs e)
        {
            HomeForm existingMainForm = Application.OpenForms.OfType<HomeForm>().FirstOrDefault();
            existingMainForm.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
