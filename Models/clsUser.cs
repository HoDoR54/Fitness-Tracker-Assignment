using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Models
{
    public class clsUser
    {
            public string Username { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public string Gender { get; set; }
            public DateTime DateOfBirth { get; set; }
            public decimal CurrentWeight { get; set; }
            public decimal WeightGoal { get; set; }
            public decimal HeightInCm { get; set; }
            public int CalorieGoal {  get; set; }

        public clsUser(string username, string name, string password, string gender, DateTime dateOfBirth, decimal currentWeight, decimal weightGoal, decimal heightInCm, int calorieGoal)
        {
            Username = username;
            Name = name;
            Password = password;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            CurrentWeight = currentWeight;
            WeightGoal = weightGoal;
            HeightInCm = heightInCm;
            CalorieGoal = calorieGoal;
        }
    }
}
