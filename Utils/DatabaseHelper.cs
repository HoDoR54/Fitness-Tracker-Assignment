using Fitness_Tracker.DB_Fitness_TrackerDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker.Utils
{
    internal class DatabaseHelper
    {
        tblUserTableAdapter userAdapter = new tblUserTableAdapter();
        DataTable userData = new DataTable();

        tblActivityUserTableAdapter auAdapter = new tblActivityUserTableAdapter();
        tblActivityTableAdapter actAdapter = new tblActivityTableAdapter();
        tblActivityMetricTableAdapter amAdapter = new tblActivityMetricTableAdapter();


        public string AutoGenerateId()
        {
            string trainerId = "FIT001";
            userData = userAdapter.GetData();

            if (userData.Rows.Count > 0)
            {
                string lastId = userData.Rows[userData.Rows.Count - 1]["id"].ToString();
                int numericPart = int.Parse(lastId.Substring(3)) + 1;
                trainerId = "FIT" + numericPart.ToString("D3");
            }

            return trainerId;
        }
        public bool InsertUser(clsUser user)
        {
            try
            {
                int dataInserted = userAdapter.Insert(AutoGenerateId(), user.Username, user.Name, user.DateOfBirth, user.Gender, user.CurrentWeight, user.WeightGoal, user.HeightInCm, user.CalorieGoal, user.Password);
                return dataInserted > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CheckAccountExistence(string username, string password)
        {
            clsUser user = GetUserByUsername(username);

            if (user == null)
                return false;

            return user.Password == password;
        }


        public clsUser GetUserByUsername(string username)
        {
            userData = userAdapter.GetData();

            DataRow matchedRow = userData.AsEnumerable()
                .FirstOrDefault(row => row["username"].ToString() == username);
            if (matchedRow != null)
            {
                return new clsUser(
                    username: matchedRow["username"].ToString(),
                    name: matchedRow["name"].ToString(),
                    dateOfBirth: Convert.ToDateTime(matchedRow["dateOfBirth"]),
                    gender: matchedRow["gender"].ToString(),
                    currentWeight: Convert.ToDecimal(matchedRow["currentWeight"]),
                    weightGoal: Convert.ToDecimal(matchedRow["weightGoal"]),
                    heightInCm: Convert.ToInt32(matchedRow["height"]),
                    password: matchedRow["password"].ToString(),
                    calorieGoal: Convert.ToInt32(matchedRow["dailyCalorie"])
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

        public bool DeleteUserActivity(string activity, string username)
        {
            try
            {
                int? activityId = actAdapter.GetActivityIdByName(activity);
                string userId = userAdapter.GetIdByUsername(username);
                int rowsInserted = auAdapter.DeleteUserActivity(userId, activityId);
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
    }
}
