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
            activityMetrics[activity] = databaseHelper.GetMetricsByActivityName(activity);
            var metrics = activityMetrics[activity];

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

        List<Dictionary<string, List<decimal>>> activitiesMetricsValues = new List<Dictionary<string, List<decimal>>>(); // list to store today's activities and respective metric values

        private void btnAddAct_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<decimal>> activityMetricValues = new Dictionary<string, List<decimal>>();
            string activity = cboActivities.SelectedItem.ToString().ToLower();


            // list to store the values
            List<decimal> metricValues = new List<decimal>();
            metricValues.Add(numMet1.Value);
            metricValues.Add(numMet2.Value);
            metricValues.Add(numMet3.Value);

            // assign the list to the dictionary
            activityMetricValues.Add(activity, metricValues);

            //assign the dictionary to the list
            if (ValidateActivityInput())
            {
                activitiesMetricsValues.Add(activityMetricValues);
                UpdateListDisplay(activitiesMetricsValues);

            }
        }

        public bool ValidateActivityInput ()
        {
            bool isValid = true;

            if (numMet1.Value <= 0 && numMet2.Value <= 0 && numMet3.Value <= 0)
            {
                MessageBox.Show("Please fill the metric values.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isValid = false;
            }

            return isValid;
        }

        public void UpdateListDisplay (List<Dictionary<string, List<decimal>>> activitiesMetricsValues)
        {
            List<string> addedActivities = new List<string>();
            foreach (var activityDict in activitiesMetricsValues)
            {
                foreach (var key in activityDict.Keys)
                {
                    addedActivities.Add(key);
                }
            }
            lblResult.TextAlign = ContentAlignment.TopLeft;
            lblResult.Text = string.Join("\n", addedActivities);
        }
    }
}
