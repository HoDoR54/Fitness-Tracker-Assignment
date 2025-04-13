using Fitness_Tracker.DB_Fitness_TrackerDataSetTableAdapters;
using Fitness_Tracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker.Utils
{
    internal class DatabaseHelper
    {
        private tblUserTableAdapter userAdapter = new tblUserTableAdapter();
        private DataTable userData = new DataTable(); 
        private tblActivityUserTableAdapter auAdapter = new tblActivityUserTableAdapter();
        private tblActivityTableAdapter actAdapter = new tblActivityTableAdapter();
        private tblActivityMetricTableAdapter amAdapter = new tblActivityMetricTableAdapter();

        // this method is used to generate a new userId for the new user
        public string AutoGenerateUserId(string lastUserId)
        {
            string userId = "FIT001";

            if (!string.IsNullOrEmpty(lastUserId))
            {
                if (lastUserId.Length < 6 || !lastUserId.StartsWith("FIT"))
                {
                    return null;
                }

                int lastUserNumericPart = int.Parse(lastUserId.Substring(3));

                int numericPart = lastUserNumericPart + 1;
                userId = "FIT" + numericPart.ToString("D3");
            }

            return userId;
        }


        // this method is used to insert a new user into the database (in registratrion form)
        public bool InsertUser(User user)
        {
            try
            {
                userData = userAdapter.GetData();
                string lastUserId = userData.Rows.Count > 0 ? userData.Rows[userData.Rows.Count - 1]["userId"].ToString() : null;
                string newId = AutoGenerateUserId(lastUserId);
                if (newId == null)
                {
                    return false;
                }

                int dataInserted = userAdapter.Insert(AutoGenerateUserId(lastUserId), user.GetUsername(), user.GetName(), user.GetDateOfBirth(), user.GetGender(), user.GetCurrentWeight(), user.GetWeightGoal(), user.GetHeightInCm(), user.GetCalorieGoal(), user.GetPassword());
                return dataInserted > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // two methods below are used to check if the username already exists in the database
        // and if so, check if the password is correct
        public bool CheckAccountExistence (string username)
        {
            User user = GetUserByUsername(username);
            return user != null;
        }

        public bool CheckPassword (string username, string password)
        {
            User user = GetUserByUsername(username);
            return user.GetPassword() == password;
        }

        // this method is used to get the user data from the database
        public User GetUserByUsername(string username)
        {
            userData = userAdapter.GetData();

            DataRow matchedRow = userData.AsEnumerable()
                .FirstOrDefault(row => row["username"].ToString() == username);
            if (matchedRow != null)
            {
                return new User(
                    username: matchedRow["username"].ToString(),
                    name: matchedRow["name"].ToString(),
                    dateOfBirth: Convert.ToDateTime(matchedRow["dateOfBirth"]),
                    gender: matchedRow["gender"].ToString(),
                    currentWeight: Convert.ToDecimal(matchedRow["currentWeight"]),
                    weightGoal: Convert.ToDecimal(matchedRow["weightGoal"]),
                    heightInCm: Convert.ToInt32(matchedRow["height"]),
                    password: matchedRow["password"].ToString(),
                    dailyCalorie: Convert.ToInt32(matchedRow["dailyCalorie"])
                );
            }
            return null;
        }

        // update user calorie goal (a User attribute)
        public bool UpdateUserCalGoal (int calorieGoal, string username)
        {
            try
            {
                int dataUpdated = userAdapter.UpdateUserCalGoal(calorieGoal, username);
                return dataUpdated > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // add user activity to the database
        public bool AddUserActivity(Activity activity, string username, decimal burntCalories)
        {
            try
            {
                DateTime now = DateTime.Now;
                int? activityId = activity.GetActivityId();
                string userId = userAdapter.GetIdByUsername(username);
                int rowsInserted = auAdapter.InsertUserActivity(activityId, userId, burntCalories, now);
                return rowsInserted > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // get all activities and their metrics from the database
        public List<Activity> GetAllActivities()
        {
            try
            {
                DB_Fitness_TrackerDataSet.tblActivityDataTable activityData = new DB_Fitness_TrackerDataSet.tblActivityDataTable();

                List<Activity> activities = new List<Activity>();
                actAdapter.Fill(activityData);

                for (int i = 0; i < activityData.Rows.Count; i++)
                {
                    // add activity to the list
                    int activityId = Convert.ToInt32(activityData[i]["id"]);
                    string activityName = activityData[i]["activityName"].ToString();
                    Activity newActivity = new Activity(activityId, activityName);
                    activities.Add(newActivity);

                    // get and add metrics to the activity
                    DB_Fitness_TrackerDataSet.tblActivityMetricDataTable metricData = new DB_Fitness_TrackerDataSet.tblActivityMetricDataTable();
                    amAdapter.GetMetricsByActivityName(metricData, activityName);

                    List<Metric> metrics = new List<Metric>();
                    for (int m = 0; m < metricData.Rows.Count; m++)
                    {
                        int metricId = Convert.ToInt32(metricData[m]["id"]);
                        string metricName = metricData[m]["metricName"].ToString();
                        string metricUnit = metricData[m]["metricUnit"].ToString();
                        Metric newMetric = new Metric(metricId, metricName, metricUnit);
                        metrics.Add(newMetric);
                    }

                    newActivity.SetMetrics(metrics);
                }

                return activities;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // get the total calories burnt today
        public decimal GetTodayCalories(User currentUser)
        {
            try
            {
                DateTime today = DateTime.Today;
                DB_Fitness_TrackerDataSet.tblActivityUserDataTable actUserData = new DB_Fitness_TrackerDataSet.tblActivityUserDataTable();
                string userId = userAdapter.GetIdByUsername(currentUser.GetUsername());

                int rowCount = auAdapter.GetTodayCalories(actUserData, today.ToString("yyyy-MM-dd"), userId);

                decimal totalCalories = 0;
                foreach (DataRow row in actUserData.Rows)
                {
                    if (row["burntCalorie"] != DBNull.Value)
                    {
                        totalCalories += Convert.ToDecimal(row["burntCalorie"]);
                    }
                }
                return decimal.Round(totalCalories, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        // get the activity history of the user
        public DB_Fitness_TrackerDataSet.GetHistoryDataTable GetActivityHistory (User currentUser)
        {
            try
            {
                GetHistoryTableAdapter historyAdapter = new GetHistoryTableAdapter();
                string userId = userAdapter.GetIdByUsername(currentUser.GetUsername());
                DB_Fitness_TrackerDataSet.GetHistoryDataTable historyData = historyAdapter.GetHistory(userId);
                return historyData.Rows.Count > 0 ? historyData : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // get the activity history of the user by activity name (used for the search feature)
        public DB_Fitness_TrackerDataSet.GetHistoryDataTable GetHistoryByActivity(User currentUser, string activity)
        {
            try
            {
                GetHistoryTableAdapter historyAdapter = new GetHistoryTableAdapter();
                string userId = userAdapter.GetIdByUsername(currentUser.GetUsername());
                DB_Fitness_TrackerDataSet.GetHistoryDataTable historyData = historyAdapter.GetHistoryByActivity(userId, activity.ToLower());
                return historyData.Rows.Count > 0 ? historyData : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        // delete the account permanently
        public void DeleteAccount (string username)
        {
            try
            {
                // delete the related data first
                string userId = userAdapter.GetIdByUsername(username);
                auAdapter.DeleteUserActivity(userId);

                // delete the account
                userAdapter.DeleteAccount(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
