using Fitness_Tracker.DB_Fitness_TrackerDataSetTableAdapters;
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

        public bool CheckAccountExistence (string username)
        {
            User user = GetUserByUsername(username);
            return user == null ? false : true;
        }

        public bool CheckPassword (string username, string password)
        {
            User user = GetUserByUsername(username);
            return user.GetPassword() == password ? true : false;
        }

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

        public bool AddUserActivity(string activity, string username, decimal burntCalories)
        {
            DateTime now = DateTime.Now;
            try
            {
                int? activityId = actAdapter.GetActivityIdByName(activity);
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

        public List<string> GetAllActivities ()
        {
            DB_Fitness_TrackerDataSet.tblActivityDataTable activityData = new DB_Fitness_TrackerDataSet.tblActivityDataTable();
            List<string> activities = new List<string>();
            actAdapter.GetAllActivities(activityData);

            for (int i = 0; i < activityData.Rows.Count; i++)
            {
                activities.Add(activityData.Rows[i]["activityName"].ToString());
            }
            return activities;
        }

        public List<Dictionary<string, string>> GetMetricsByActivityName (string activityName)
        {
            DB_Fitness_TrackerDataSet.tblActivityMetricDataTable metricData = new DB_Fitness_TrackerDataSet.tblActivityMetricDataTable();
            List<Dictionary<string, string>> metrics = new List<Dictionary<string, string>>();

            amAdapter.GetMetricsByActivityName(metricData, activityName);

            for (int i = 0; i < metricData.Rows.Count; i++)
            {
                Dictionary<string, string> metricAndUnit = new Dictionary<string, string>();
                metricAndUnit.Add(metricData[i]["metricName"].ToString(), metricData[i]["metricUnit"].ToString());
                metrics.Add(metricAndUnit);
            }
            return metrics;
        }

        public decimal GetTodayCalories(User currentUser)
        {
            DateTime today = DateTime.Today;
            DB_Fitness_TrackerDataSet.tblActivityUserDataTable actUserData = new DB_Fitness_TrackerDataSet.tblActivityUserDataTable();
            string userId = userAdapter.GetIdByUsername(currentUser.GetUsername());
            try
            {
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

        public DB_Fitness_TrackerDataSet.GetHistoryDataTable GetActivityHistory (User currentUser)
        {
            GetHistoryTableAdapter historyAdapter = new GetHistoryTableAdapter();
            string userId = userAdapter.GetIdByUsername(currentUser.GetUsername());
            try
            {
                DB_Fitness_TrackerDataSet.GetHistoryDataTable historyData = historyAdapter.GetHistory(userId);
                return historyData.Rows.Count > 0 ? historyData : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DB_Fitness_TrackerDataSet.GetHistoryDataTable GetHistoryByActivity(User currentUser, string activity)
        {
            GetHistoryTableAdapter historyAdapter = new GetHistoryTableAdapter();
            string userId = userAdapter.GetIdByUsername(currentUser.GetUsername());

            try
            {
                DB_Fitness_TrackerDataSet.GetHistoryDataTable historyData = historyAdapter.GetHistoryByActivity(userId, activity.ToLower());
                return historyData.Rows.Count > 0 ? historyData : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


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
