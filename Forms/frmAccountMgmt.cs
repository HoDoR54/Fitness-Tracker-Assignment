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
    public partial class frmAccountMgmt : Form
    {
        DatabaseHelper databaseHelper = new DatabaseHelper();
        clsUser currentUser;
        public frmAccountMgmt(clsUser user)
        {
            InitializeComponent();
            currentUser = user;
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
                databaseHelper.DeleteAccount(currentUser.Username);
                MessageBox.Show($"Account '{currentUser.Username}' has been successfully deleted.", "Account deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmRegistration frmRegistration = new frmRegistration();
                frmRegistration.Show();
                this.Hide();
            }
        }

        private void frmAccountMgmt_Load(object sender, EventArgs e)
        {
            lblName.Text = currentUser.Name;
            lblUsername.Text = $"Username: {currentUser.Username}";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
            this.Hide();
        }

        private void btnAnthAcc_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
