using System;

namespace Fitness_Tracker.Utils
{
    public class User
    {
        private string _username;
        private string _name;
        private string _password;
        private string _gender;
        private DateTime _dateOfBirth;
        private decimal _currentWeightInKg;
        private decimal _weightGoalInKg;
        private decimal _heightInCm;
        private int _dailyCalorie;

        public User(string username, string name, string password, string gender, DateTime dateOfBirth, decimal currentWeight, decimal weightGoal, decimal heightInCm, int dailyCalorie)
        {
            _username = username;
            _name = name;
            _password = password;
            _gender = gender;
            _dateOfBirth = dateOfBirth;
            _currentWeightInKg = currentWeight;
            _weightGoalInKg = weightGoal;
            _heightInCm = heightInCm;
            _dailyCalorie = dailyCalorie;
        }

        public string GetUsername() => _username;
        public string GetName() => _name;
        public string GetGender() => _gender;
        public DateTime GetDateOfBirth() => _dateOfBirth;
        public decimal GetCurrentWeight() => _currentWeightInKg;
        public decimal GetWeightGoal() => _weightGoalInKg;
        public decimal GetHeightInCm() => _heightInCm;
        public int GetCalorieGoal() => _dailyCalorie;

        public string GetPassword() => _password;
        public void SetCalorieGoal(int newGoal)
        {
            if (newGoal > 0) _dailyCalorie = newGoal;
        }
    }
}
