using Fitness_Tracker.Models;
using Fitness_Tracker.Services;
using Fitness_Tracker.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Testing
{
    internal class Tests
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();
        private CalorieHelper _calorieHelper = new CalorieHelper();

        public Tests()
        {
            TestAutoGenerateUserId();
            TestGetMETForActivity();
            TestCalculateCalories();
        }

        // Test the AutoGenerateUserId method
        public void TestAutoGenerateUserId()
        {
            // WB-01: null lastUserId
            string response = _dbHelper.AutoGenerateUserId(null);
            Console.WriteLine("Test WB-01");
            Console.WriteLine($"Response: {response}");
            Console.WriteLine(response == "FIT001" ? "Passed" : "Failed");
            Console.WriteLine($"\n");

            // WB-02: lastUserId is in a valid format, "FIT005"
            string lastUserId = "FIT005";
            response = _dbHelper.AutoGenerateUserId(lastUserId);
            Console.WriteLine("Test WB-02");
            Console.WriteLine($"Response: {response}");
            Console.WriteLine(response == "FIT006" ? "Passed" : "Failed");
            Console.WriteLine($"\n");

            // WB-03: lastUserId is "FIT999"
            lastUserId = "FIT999";
            response = _dbHelper.AutoGenerateUserId(lastUserId);
            Console.WriteLine("Test WB-03");
            Console.WriteLine($"Response: {response}");
            Console.WriteLine(response == "FIT1000" ? "Passed" : "Failed");
            Console.WriteLine($"\n");

            // WB-04: lastUserId is in an invalid format, "User-02"
            lastUserId = "User-02";
            response = _dbHelper.AutoGenerateUserId(lastUserId);
            Console.WriteLine("Test WB-04");
            Console.WriteLine($"Response: {response}");
            Console.WriteLine(response == null ? "Passed" : "Failed");
            Console.WriteLine($"\n");

            Console.ReadLine();
        }

        // Test the get MET by activity method
        public void TestGetMETForActivity()
        {
            // WB-05: Valid activity "walking"
            string activity = "walking";
            decimal metValue = _calorieHelper.GetMETForActivity(activity);
            Console.WriteLine("Test WB-05");
            Console.WriteLine($"Response: {metValue}");
            Console.WriteLine(metValue == 3.8m ? "Passed" : "Failed");
            Console.WriteLine($"\n");

            // WB-06: Invalid activity "dancing"
            activity = null;
            metValue = _calorieHelper.GetMETForActivity(activity);
            Console.WriteLine("Test WB-06");
            Console.WriteLine($"Response: {metValue}");
            Console.WriteLine(metValue == 0 ? "Passed" : "Failed");
            Console.WriteLine($"\n");

            // WB-07: Invalid activity "walk"
            activity = "walk";
            metValue = _calorieHelper.GetMETForActivity(activity);
            Console.WriteLine("Test WB-07");
            Console.WriteLine($"Response: {metValue}");
            Console.WriteLine(metValue == 0 ? "Passed" : "Failed");
            Console.WriteLine($"\n");

            // WB-08: Empty string
            activity = "";
            metValue = _calorieHelper.GetMETForActivity(activity);
            Console.WriteLine("Test WB-08");
            Console.WriteLine($"Response: {metValue}");
            Console.WriteLine(metValue == 0 ? "Passed" : "Failed");
            Console.WriteLine($"\n");

            Console.ReadLine();
        }

        // Test the CalculateCalories method
        public void TestCalculateCalories()
        {
            Activity activity = new Activity(1, "walking");
            // WB-09: Valid inputs for "walking"
            var activityMetricValues = new Dictionary<Activity, List<decimal>>()
                {
                    { activity, new List<decimal> { 1000, 3.0m, 45.0m } }
                };
            decimal metValue = 3.8m;
            decimal weight = 70.00m;
            decimal caloriesBurned = _calorieHelper.CalculateCalories(activityMetricValues, metValue, weight);
            Console.WriteLine("Test WB-09");
            Console.WriteLine($"Response: {caloriesBurned}");
            Console.WriteLine(caloriesBurned > 0 ? "Passed" : "Failed");
            Console.WriteLine("\n");

            // WB-10: Invalid activity name "walk"
            activity.SetActivityName("walk");
            activityMetricValues = new Dictionary<Activity, List<decimal>>()
                {
                    { activity, new List<decimal> { 1000, 3.0m, 45.0m } }
                };
            caloriesBurned = _calorieHelper.CalculateCalories(activityMetricValues, metValue, weight);
            Console.WriteLine("Test WB-10");
            Console.WriteLine($"Response: {caloriesBurned}");
            Console.WriteLine(caloriesBurned == 0 ? "Passed" : "Failed");
            Console.WriteLine("\n");

            // WB-11: Missing one metric (e.g., only two values for "walk")
            activityMetricValues = new Dictionary<Activity, List<decimal>>()
                {
                    { activity, new List<decimal> { 1000, 3.0m } }
                };
            caloriesBurned = _calorieHelper.CalculateCalories(activityMetricValues, metValue, weight);
            Console.WriteLine("Test WB-11");
            Console.WriteLine($"Response: {caloriesBurned}");
            Console.WriteLine(caloriesBurned == 0 ? "Passed" : "Failed");
            Console.WriteLine("\n");

            // WB-12: MET value of 0
            activityMetricValues = new Dictionary<Activity, List<decimal>>()
                {
                    { activity, new List<decimal> { 1000, 3.0m, 45.0m } }
                };
            metValue = 0;
            caloriesBurned = _calorieHelper.CalculateCalories(activityMetricValues, metValue, weight);
            Console.WriteLine("Test WB-12");
            Console.WriteLine($"Response: {caloriesBurned}");
            Console.WriteLine(caloriesBurned == 0 ? "Passed" : "Failed");
            Console.WriteLine("\n");

            // WB-13: Bodyweight of 0 kg
            activityMetricValues = new Dictionary<Activity, List<decimal>>()
                {
                    { activity, new List<decimal> { 1000, 3.0m, 45.0m } }
                };
            weight = 0;
            caloriesBurned = _calorieHelper.CalculateCalories(activityMetricValues, metValue, weight);
            Console.WriteLine("Test WB-13");
            Console.WriteLine($"Response: {caloriesBurned}");
            Console.WriteLine(caloriesBurned == 0 ? "Passed" : "Failed");
            Console.WriteLine("\n");

            Console.ReadLine();
        }

    }
}
