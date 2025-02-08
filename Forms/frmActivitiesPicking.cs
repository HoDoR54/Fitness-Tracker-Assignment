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
    public partial class frmActivitiesPicking : Form
    {
        DatabaseHelper databaseHelper = new DatabaseHelper();
        clsUser currentUser;
        public frmActivitiesPicking(clsUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void frmActivityTracking_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        List<string> chosenActivities = new List<string>();

        private void frmActivitiesPicking_Load(object sender, EventArgs e)
        {
            cbxWalking.Checked = true;
            cbxSwimming.Checked = true;

            chosenActivities.Clear();
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    chosenActivities.Add(checkBox.Text);
                }
            }

            updateListDisplay();
        }


        public void updateListDisplay()
        {
            lblActivitiesListDisplay.Text = string.Join("\n", chosenActivities
                .Select((activity, index) => $"{index + 1}) {activity.ToLower()}"));
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox == null) return;

            string activity = checkBox.Text.ToLower();

            if (!checkBox.Checked && (activity == "walking" || activity == "swimming"))
            {
                MessageBox.Show("You cannot remove the default activities.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox.Checked = true;
                return;
            }

            if (checkBox.Checked && chosenActivities.Count >= 6)
            {
                MessageBox.Show("You can only select up to 6 activities.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox.Checked = false;
                return;
            }

            if (checkBox.Checked && !chosenActivities.Contains(checkBox.Text))
            {
                databaseHelper.AddUserActivity(checkBox.Text.Trim().ToLower(), currentUser.Username);
                chosenActivities.Add(checkBox.Text);
            }
            else if (!checkBox.Checked)
            {
                databaseHelper.DeleteUserActivity(checkBox.Text.Trim().ToLower(), currentUser.Username);
                chosenActivities.Remove(checkBox.Text);
            }
            updateListDisplay();

        }


    }
}
