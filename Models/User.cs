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
        private int _calorieGoal;

        public User(string username, string name, string password, string gender, DateTime dateOfBirth, decimal currentWeight, decimal weightGoal, decimal heightInCm, int calorieGoal)
        {
            _username = username;
            _name = name;
            _password = password;
            _gender = gender;
            _dateOfBirth = dateOfBirth;
            _currentWeightInKg = currentWeight;
            _weightGoalInKg = weightGoal;
            _heightInCm = heightInCm;
            _calorieGoal = calorieGoal;
        }

        public string GetUsername() => _username;
        public string GetName() => _name;
        public string GetGender() => _gender;
        public DateTime GetDateOfBirth() => _dateOfBirth;
        public decimal GetCurrentWeight() => _currentWeightInKg;
        public decimal GetWeightGoal() => _weightGoalInKg;
        public decimal GetHeightInCm() => _heightInCm;
        public int GetCalorieGoal() => _calorieGoal;

        public string GetPassword() => _password;

        public bool VerifyPassword(string password) => _password == password;

        public void SetCurrentWeight(decimal newWeight)
        {
            if (newWeight > 0) _currentWeightInKg = newWeight;
        }

        public void SetWeightGoal(decimal newGoal)
        {
            if (newGoal > 0) _weightGoalInKg = newGoal;
        }

        public void SetCalorieGoal(int newGoal)
        {
            if (newGoal > 0) _calorieGoal = newGoal;
        }
    }
}
