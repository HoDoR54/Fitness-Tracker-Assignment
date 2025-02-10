using Fitness_Tracker.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker.Forms
{
    public partial class frmGoalSetting : Form
    {
        clsUser currentUser;
        public frmGoalSetting(clsUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void frmGoalSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMain mainForm = new frmMain(databaseHelper.GetUserByUsername(currentUser.Username));
            mainForm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        DatabaseHelper databaseHelper = new DatabaseHelper();

        private void btnSetGoal_Click(object sender, EventArgs e)
        {
            int intake = (int)numIntake.Value;
            int goal = (int)numGoal.Value;

            if (intake <= 0)
            {
                MessageBox.Show("Please enter a valid daily calorie intake.", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numIntake.Focus();
            }
            else if (goal <= 0)
            {
                MessageBox.Show("Please enter a valid daily calorie burn goal.", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numGoal.Focus();
            }
            else if (intake < 1000 || intake > 5000)
            {
                MessageBox.Show("Calorie intake should be between 1,000 and 5,000 kcal.", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numIntake.Focus();
            }
            else if (goal < 200 || goal > 1500)
            {
                MessageBox.Show("Calorie burn goal is recommended to be between 200 and 1,500 kcal.", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numGoal.Focus();
            }
            else if (goal >= intake)
            {
                MessageBox.Show("Warning: Your goal exceeds your intake, which may be unrealistic.", "Unrealistic value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numGoal.Focus();
            }
            else
            {
                currentUser.CalorieGoal = goal;
                databaseHelper.UpdateUserCalGoal(goal, currentUser.Username);

                MessageBox.Show("Goal set successfully!", "Goal set", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMain existingMainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                if (existingMainForm != null)
                {
                    existingMainForm.UpdateCalorieGoal(goal);
                }

                this.Close();
            }
        }
    }
}
