using Fitness_Tracker.DBFitness_Tracker_WinFormDataSetTableAdapters;
using Fitness_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker.Utils
{
    internal class DatabaseHelper
    {
        tblUserTableAdapter adapter = new tblUserTableAdapter();
        DataTable userData = new DataTable();

        public string AutoGenerateId()
        {
            string trainerId = "FIT001";
            userData = adapter.GetData();

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
                int dataInserted = adapter.Insert(AutoGenerateId(), user.Username, user.Name, user.DateOfBirth, user.Gender, user.CurrentWeight, user.WeightGoal, user.HeightInCm, user.Password, user.CalorieGoal);
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
            userData = adapter.GetData();

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
                    calorieGoal: Convert.ToInt32(matchedRow["calorieGoal"])
                );
            }

            return null;
        }

        public bool UpdateUserCalGoal (int calorieGoal, string username)
        {
            try
            {
                int dataUpdated = adapter.UpdateUserCalGoal(calorieGoal, username);
                return dataUpdated > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
