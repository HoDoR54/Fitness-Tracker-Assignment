using Fitness_Tracker.Services;
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
        private clsUser currentUser;
        private List<Dictionary<string, List<decimal>>> activitiesMetricsValues = new List<Dictionary<string, List<decimal>>>();
        private HashSet<string> addedActivities = new HashSet<string>();

        public frmCalories(clsUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void frmCalories_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private List<string> activities = databaseHelper.GetAllActivities();

        private void frmCalories_Load(object sender, EventArgs e)
        {
            lblToday.Text = DateTime.Today.ToString("yyyy-MM-dd");
            lblGoal.Text = $"Calorie goal: {currentUser.CalorieGoal}";

            if (activities.Count > 0)
            {
                cboActivities.DataSource = activities;
                cboActivities.SelectedIndex = 0;
                UpdateUI(activities[0]);
            }

            UpdateProgress();
        }

        public void UpdateProgress()
        {
            decimal todayCalories = databaseHelper.GetTodayCalories(currentUser);
            decimal progressPercent = (todayCalories / currentUser.CalorieGoal) * 100;
            progressBar.Value = (int)(progressPercent);
            if (todayCalories < currentUser.CalorieGoal)
            {
                lblPercent.Text = $"{todayCalories} / {currentUser.CalorieGoal} kcals ({Math.Round(progressPercent, 2)}%)";
            }

            if (todayCalories >= currentUser.CalorieGoal)
            {
                lblPercent.Text = $"{currentUser.CalorieGoal}/{currentUser.CalorieGoal} kcals (100%)";
                MessageBox.Show("Congratulations! You have reached your daily calorie goal.", "Goal reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void UpdateUI(string activity)
        {
            var metrics = databaseHelper.GetMetricsByActivityName(activity);

            lblMetric1.Text = $"{metrics[0].Keys.First()}:";
            lblUnit1.Text = metrics[0].Values.First();

            lblMetric2.Text = $"{metrics[1].Keys.First()}:";
            lblUnit2.Text = metrics[1].Values.First();

            lblMetric3.Text = $"{metrics[2].Keys.First()}:";
            lblUnit3.Text = metrics[2].Values.First();

            numMet1.Value = 0;
            numMet2.Value = 0;
            numMet3.Value = 0;
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI(cboActivities.SelectedItem.ToString().ToLower());
        }

        private void btnAddAct_Click(object sender, EventArgs e)
        {
            string activity = cboActivities.SelectedItem.ToString().Trim().ToLower();

            if (ValidateActivityInput(activity))
            {
                // Update the list
                List<decimal> metricValues = new List<decimal>
                {
                    numMet1.Value,
                    numMet2.Value,
                    numMet3.Value
                };

                Dictionary<string, List<decimal>> activityMetricValues = new Dictionary<string, List<decimal>>
                {
                    { activity, metricValues }
                };

                activitiesMetricsValues.Add(activityMetricValues);
                addedActivities.Add(activity); 


                // Calculate calories burnt
                decimal caloriesBurnt = CalorieCalculator.CalculateCalories(activityMetricValues, activity, currentUser.CurrentWeight);

                // Update the database
                databaseHelper.AddUserActivity(activity, currentUser.Username, caloriesBurnt);

                // Update the progress bar
                UpdateProgress();
            }
        }

        public bool ValidateActivityInput(string activity)
        {
            if (numMet1.Value <= 0 && numMet2.Value <= 0 && numMet3.Value <= 0)
            {
                MessageBox.Show("Please fill the metric values.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (addedActivities.Contains(activity))
            {
                MessageBox.Show("You have already added this activity.", "Duplicated activity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory frmHistory = new frmHistory(currentUser);
            frmHistory.ShowDialog();
        }
    }
}
