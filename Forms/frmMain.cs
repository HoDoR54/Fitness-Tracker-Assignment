using Fitness_Tracker.Models;
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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGoalSetting frmGoalSetting = new frmGoalSetting(currentUser.Username);
            frmGoalSetting.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmActivitiesPicking frmActivityTracking = new frmActivitiesPicking();
            frmActivityTracking.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCalories frmCalories = new frmCalories();
            frmCalories.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmAccountMgmt frmAccountMgmt = new frmAccountMgmt();  
            frmAccountMgmt.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"Username: {currentUser.Username}";
            lblCalories.Text = $"Daily calorie buring goal: {currentUser.CalorieGoal}";
        }
    }
}
