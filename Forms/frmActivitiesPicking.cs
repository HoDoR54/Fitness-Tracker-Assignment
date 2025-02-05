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
        public frmActivitiesPicking()
        {
            InitializeComponent();
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
                .Select((activity, index) => $"{index + 1}. {activity.ToLower()}"));
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox == null) return;

            if (!checkBox.Checked && (checkBox.Text.ToLower() == "walking" || checkBox.Text.ToLower() == "swimming"))
            {
                MessageBox.Show("You cannot remove the default activities.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox.Checked = true;
                return;
            }
            if (checkBox.Checked)
            {
                if (!chosenActivities.Contains(checkBox.Text))
                {
                    chosenActivities.Add(checkBox.Text);
                }
            }
            else
            {
                chosenActivities.Remove(checkBox.Text);
            }

            updateListDisplay();
        }


    }
}
