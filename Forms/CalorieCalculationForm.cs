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
    public partial class CalorieCalculationForm : Form
    {
        private static DatabaseHelper _dbHelper = new DatabaseHelper();
        private static CalorieHelper _calorieHelper = new CalorieHelper();
        private User _currentUser;

        public CalorieCalculationForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void frmCalories_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private List<string> activities = _dbHelper.GetAllActivities();

        private void frmCalories_Load(object sender, EventArgs e)
        {
            lblToday.Text = DateTime.Today.ToString("yyyy-MM-dd");
            lblGoal.Text = $"Calorie goal: {_currentUser.GetCalorieGoal()}";

            if (activities.Count > 0)
            {
                activityComboBox.DataSource = activities;
                activityComboBox.SelectedIndex = 0;
                UpdateUI(activities[0]);
            }

            UpdateProgress(false);
        }

        public void UpdateProgress(bool isAdding)
        {
            decimal todayCalories = _dbHelper.GetTodayCalories(_currentUser);
            decimal progressPercent = (todayCalories / _currentUser.GetCalorieGoal()) * 100;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = progressPercent >= 100 ? 100 : Convert.ToInt32(progressPercent);
            if (todayCalories < _currentUser.GetCalorieGoal())
            {
                percentLabel.Text = $"{todayCalories} / {_currentUser.GetCalorieGoal()} kcals ({Math.Round(progressPercent, 2)}%)";
            }

            if (todayCalories >= _currentUser.GetCalorieGoal() && isAdding)
            {
                percentLabel.Text = $"{_currentUser.GetCalorieGoal()}/{_currentUser.GetCalorieGoal()} kcals (100%)";
                MessageBox.Show("Congratulations! You have reached your daily calorie goal.", "Goal reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void UpdateUI(string activity)
        {
            var metrics = _dbHelper.GetMetricsByActivityName(activity);

            metricOneLabel.Text = $"{metrics[0].Keys.First()}:";
            unitOneLabel.Text = metrics[0].Values.First();

            metricTwoLabel.Text = $"{metrics[1].Keys.First()}:";
            unitTwoLabel.Text = metrics[1].Values.First();

            metricThreeLabel.Text = $"{metrics[2].Keys.First()}:";
            unitThreeLabel.Text = metrics[2].Values.First();

            metricOne.Value = 0;
            metricTwo.Value = 0;
            metricThree.Value = 0;
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI(activityComboBox.SelectedItem.ToString().ToLower());
        }

        private void btnAddAct_Click(object sender, EventArgs e)
        {
            string activity = activityComboBox.SelectedItem.ToString().Trim().ToLower();

            if (ValidateActivityInput(activity))
            {
                // Update the list
                List<decimal> metricValues = new List<decimal>
                {
                    metricOne.Value,
                    metricTwo.Value,
                    metricThree.Value
                };

                Dictionary<string, List<decimal>> activityMetricValues = new Dictionary<string, List<decimal>>
                {
                    { activity, metricValues }
                };

                // Calculate calories burnt
                decimal metValue = _calorieHelper.GetMETForActivity(activity);
                if (metValue == 0)
                {
                    MessageBox.Show("Invalid activity or metric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal caloriesBurnt = _calorieHelper.CalculateCalories(activityMetricValues, metValue, _currentUser.GetCurrentWeight());

                // Update the database
                _dbHelper.AddUserActivity(activity, _currentUser.GetUsername(), caloriesBurnt);

                // Update the progress bar
                UpdateProgress(true);

                // Clear the fields
                metricOne.Value = 0;
                metricTwo.Value = 0;
                metricThree.Value = 0;
            }
        }

        public bool ValidateActivityInput(string activity)
        {
            if (metricOne.Value <= 0 || metricTwo.Value <= 0 || metricThree.Value <= 0)
            {
                MessageBox.Show("Please fill the metric values.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(_currentUser);
            historyForm.ShowDialog();
        }
    }
}
