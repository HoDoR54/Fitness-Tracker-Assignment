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
    public partial class HomeForm : Form
    {
        private User _currentUser;
        public HomeForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = $"Welcome, {_currentUser.GetUsername()}";
            char usernameFirstLetter = _currentUser.GetUsername()[0];
            toAccountButton.Text = $"{usernameFirstLetter}";
            UpdateCalorieGoal(_currentUser.GetCalorieGoal());
        }

        public void UpdateCalorieGoal(int goal)
        {
            calorieGoalLabel.Text = "Daily calorie burning goal: " + (goal != 0 ? goal.ToString() : "not set");
        }


        private void toGoalButton_Click(object sender, EventArgs e)
        {
            GoalSettingForm goalForm = new GoalSettingForm(_currentUser);
            goalForm.ShowDialog();
        }

        private void toAccountButton_Click(object sender, EventArgs e)
        {
            AccountManagementForm accForm = new AccountManagementForm(_currentUser);
            accForm.ShowDialog();
        }

        private void toCaloriesButton_Click(object sender, EventArgs e)
        {
            if (_currentUser.GetCalorieGoal() != 0)
            {
                CalorieCalculationForm calorieForm = new CalorieCalculationForm(_currentUser);
                calorieForm.ShowDialog();
            } else
            {
                DialogResult result = MessageBox.Show("You must set a goal first", "Lacking a goal", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    GoalSettingForm goalSettingForm = new GoalSettingForm(_currentUser);
                    goalSettingForm.ShowDialog();
                    this.Hide();
                }
            }
        }

        private void toHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(_currentUser);
            historyForm.ShowDialog();
        }
    }
}
