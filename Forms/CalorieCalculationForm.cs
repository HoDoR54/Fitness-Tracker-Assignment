using Fitness_Tracker.Models;
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
        // instantiate necessary class instances and private fields
        private static DatabaseHelper _dbHelper = new DatabaseHelper();
        private static CalorieHelper _calorieHelper = new CalorieHelper();
        private User _currentUser;
        private List<Activity> _activities = _dbHelper.GetAllActivities();

        public CalorieCalculationForm(User user)
        {
            InitializeComponent();
            // _currentUser is passed from the main form
            _currentUser = user;
        }

        private void CalorieCalculationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        // Load event handler for the form
        private void CalorieCalculationForm_Load(object sender, EventArgs e)
        {
            // dynamic displays on the form
            dateDisplay.Text = DateTime.Today.ToString("yyyy-MM-dd");
            goalDisplay.Text = $"Calorie goal: {_currentUser.GetCalorieGoal()}";

            // populate the activity combo box with activity names
            List<string> activityNames = new List<string>();
            foreach (var activity in _activities)
            {
                activityNames.Add(activity.GetActivityName());
            }

            if (_activities.Count > 0)
            {
                activityComboBox.DataSource = activityNames;
                activityComboBox.SelectedIndex = 0;
                UpdateUI(_activities[0]);
            }

            // update the progress bar on load
            // the method handles the rest of the logics
            UpdateProgress(false);
        }

        // this method updates the progress bar and related labels
        public void UpdateProgress(bool isAdding)
        {
            // get the total calories burnt today by the user
            decimal todayCalories = _dbHelper.GetTodayCalories(_currentUser);
            // calculate the progress percentage by dividing the total calories burnt by the user's calorie goal
            decimal progressPercent = (todayCalories / _currentUser.GetCalorieGoal()) * 100;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            // set the progress bar value
            progressBar.Value = progressPercent >= 100 ? 100 : Convert.ToInt32(progressPercent);
            
            // update the label with the current progress
            if (todayCalories < _currentUser.GetCalorieGoal())
            {
                percentLabel.Text = $"{todayCalories} / {_currentUser.GetCalorieGoal()} kcals ({Math.Round(progressPercent, 2)}%)";
            }

            // if the user has reached their calorie goal, show a message box
            if (todayCalories >= _currentUser.GetCalorieGoal() && isAdding)
            {
                percentLabel.Text = $"{_currentUser.GetCalorieGoal()}/{_currentUser.GetCalorieGoal()} kcals (100%)";
                MessageBox.Show("Congratulations! You have reached your daily calorie goal.", "Goal reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // this method updates the UI with the selected activity's metrics
        public void UpdateUI(Activity activity)
        {
            List<Metric> metrics = activity.GetMetrics();

            metricOneLabel.Text = $"{metrics[0].GetMetricName()}:";
            unitOneLabel.Text = metrics[0].GetMetricUnit();

            metricTwoLabel.Text = $"{metrics[1].GetMetricName()}:";
            unitTwoLabel.Text = metrics[1].GetMetricUnit();

            metricThreeLabel.Text = $"{metrics[2].GetMetricName()}:";
            unitThreeLabel.Text = metrics[2].GetMetricUnit();

            metricOne.Value = 0;
            metricTwo.Value = 0;
            metricThree.Value = 0;
        }

        // update UI on selected activity change
        private void activityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectActivity = activityComboBox.SelectedItem.ToString().Trim().ToLower();
            foreach (var activity in _activities)
            {
                if (activity.GetActivityName().ToLower() == selectActivity)
                {
                    UpdateUI(activity);
                    break;
                }
            }
        }

        // this method handles the button click event to add activity
        private void addActivityButton_Click(object sender, EventArgs e)
        {
            string activityName = activityComboBox.SelectedItem.ToString().Trim().ToLower();
            Activity selectedActivity = null;
            foreach (Activity activity in _activities)
            {
                if (activity.GetActivityName().ToLower() == activityName)
                {
                    selectedActivity = activity;
                    break;
                }
            }

            if (ValidateActivityInput(activityName))
            {
                // Update the list
                List<decimal> metricValues = new List<decimal>
                {
                    metricOne.Value,
                    metricTwo.Value,
                    metricThree.Value
                };

                Dictionary<Activity, List<decimal>> activityMetricValues = new Dictionary<Activity, List<decimal>>
                {
                    { selectedActivity, metricValues }
                };

                // Calculate calories burnt
                decimal metValue = _calorieHelper.GetMETForActivity(activityName);
                if (metValue == 0)
                {
                    MessageBox.Show("Invalid activity or metric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal caloriesBurnt = _calorieHelper.CalculateCalories(activityMetricValues, metValue, _currentUser.GetCurrentWeight());

                // Update the database
                _dbHelper.AddUserActivity(selectedActivity, _currentUser.GetUsername(), caloriesBurnt);

                // Update the progress bar
                UpdateProgress(true);

                // Clear the fields
                metricOne.Value = 0;
                metricTwo.Value = 0;
                metricThree.Value = 0;
            }
        }

        // validate the input values
        public bool ValidateActivityInput(string activity)
        {
            if (metricOne.Value <= 0 || metricTwo.Value <= 0 || metricThree.Value <= 0)
            {
                MessageBox.Show("Please fill the metric values.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        // redirect to the history form
        private void toHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(_currentUser);
            historyForm.ShowDialog();
        }
    }
}
