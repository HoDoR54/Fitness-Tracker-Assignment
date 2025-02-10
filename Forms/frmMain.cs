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
    public partial class frmMain : Form
    {
        clsUser currentUser;
        public frmMain(clsUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"Username: {currentUser.Username}";
            UpdateCalorieGoal(currentUser.CalorieGoal);
        }

        public void UpdateCalorieGoal(int goal)
        {
            lblCalories.Text = "Daily calorie burning goal: " + (goal != 0 ? goal.ToString() : "not set");
        }


        private void btnToGoal_Click(object sender, EventArgs e)
        {
            frmGoalSetting frmGoalSetting = new frmGoalSetting(currentUser);
            frmGoalSetting.ShowDialog();
        }

        private void btnToAccount_Click(object sender, EventArgs e)
        {
            frmAccountMgmt frmAccountMgmt = new frmAccountMgmt();
            frmAccountMgmt.ShowDialog();
        }

        private void btnToCalories_Click(object sender, EventArgs e)
        {
            frmCalories frmCalories = new frmCalories(currentUser);
            frmCalories.ShowDialog();
        }

        private void btnToHistory_Click(object sender, EventArgs e)
        {
            frmHistory frmHistory = new frmHistory();
            frmHistory.ShowDialog();
        }
    }
}
