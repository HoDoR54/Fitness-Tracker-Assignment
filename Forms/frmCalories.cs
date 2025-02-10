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
    public partial class frmCalories : Form
    {
        static DatabaseHelper databaseHelper = new DatabaseHelper();
        clsUser currentUser;
        public frmCalories(clsUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void frmCalories_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        List<string> activities = databaseHelper.GetAllActivities();

        private void frmCalories_Load(object sender, EventArgs e)
        {
            lblToday.Text = DateTime.Today.ToString("yyyy-MM-dd");
            lblUsername.Text = $"Username: {currentUser.Username}";
            lblGoal.Text = $"Calorie goal: {currentUser.CalorieGoal}";

            if (activities.Count > 0)
            {
                cboActivities.DataSource = activities;
                cboActivities.SelectedIndex = 0;
            }

            UpdateUI(activities[0]);
        }

        public void UpdateUI (string activity)
        {
            Dictionary<string, List<Dictionary<string, string>>> activityMetrics = new Dictionary<string, List<Dictionary<string, string>>>();
            activityMetrics[activity] = databaseHelper.GetMatricsByActivityName(activity);
            var metrics = activityMetrics[activity];

            lblMatric1.Text = $"{metrics[0].Keys.First()}:";
            lblUnit1.Text = metrics[0].Values.First();

            lblMatric2.Text = $"{metrics[1].Keys.First()}:";
            lblUnit2.Text = metrics[1].Values.First();

            lblMatric3.Text = $"{metrics[2].Keys.First()}:";
            lblUnit3.Text = metrics[2].Values.First();
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI(cboActivities.SelectedItem.ToString().ToLower());
        }
    }
}
