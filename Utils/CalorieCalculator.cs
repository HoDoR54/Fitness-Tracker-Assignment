using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fitness_Tracker.Services
{
    internal class CalorieCalculator
    {
        public static decimal GetTotalCalories(List<Dictionary<string, List<decimal>>> activitiesMetricsValues, decimal weight)
        {
            decimal totalCalories = 0;
            foreach (var actDict in activitiesMetricsValues)
            {
                string activity = actDict.Keys.FirstOrDefault();
                decimal actCalories = CalculateCalories(actDict, activity, weight);
                totalCalories += actCalories;
            }
            return decimal.Round(totalCalories, 2);
        }
        public static decimal CalculateCalories(Dictionary<string, List<decimal>> activityMetricValues, string activity, decimal weight)
        {
            decimal caloriesBurned = 0;

            if (activityMetricValues.ContainsKey(activity))
            {
                List<decimal> metrics = activityMetricValues[activity];
                decimal metric1 = metrics[0];
                decimal metric2 = metrics[1];
                decimal metric3 = metrics[2];

                decimal MET = GetMETForActivity(activity);
                decimal timeInHours;

                switch (activity.ToLower())
                {
                    case "walking":
                        // Walking: metrics -> steps, distance, time taken (using MET)
                        timeInHours = metric3 / 60;
                        caloriesBurned = MET * weight * timeInHours;
                        break;

                    case "swimming":
                        // Swimming: metrics -> laps, time taken, average heart rate
                        timeInHours = metric2 / 60;
                        caloriesBurned = MET * weight * timeInHours;
                        break;

                    case "running":
                        // Running: metrics -> speed in m/s, distance in meters, average heart rate
                        decimal timeInSeconds = metric2 / metric1;
                        timeInHours = timeInSeconds / 3600;
                        caloriesBurned = MET * weight * timeInHours; 
                        break;

                    case "cycling":
                        // Cycling: metrics -> speed in m/s, distance, average heart rate
                        timeInSeconds = metric2 / metric1;
                        timeInHours = timeInSeconds / 3600;
                        caloriesBurned = MET * weight * timeInHours;
                        break;

                    case "jump rope":
                        // Jump Rope: metrics -> reps, time taken, average heart rate
                        timeInHours = metric2 / 60;
                        caloriesBurned = MET * weight * timeInHours;
                        break;

                    case "squatting":
                        // Squatting: metrics -> reps, time taken, average heart rate
                        timeInHours = metric2 / 60;
                        caloriesBurned = MET * weight * timeInHours;
                        break;

                    case "burpee":
                        // Burpee: metrics -> reps, time taken, average heart rate
                        timeInHours = metric2 / 60;
                        caloriesBurned = MET * weight * timeInHours;
                        break;

                    case "jumping jack":
                        // Jumping Jack: metrics -> reps, time taken, average heart rate
                        timeInHours = metric2 / 60;
                        caloriesBurned = MET * weight * timeInHours;
                        break;

                    default:
                        // If activity is unknown, return 0
                        caloriesBurned = 0;
                        break;
                }
            }

            return caloriesBurned;
        }
        private static decimal GetMETForActivity(string activity)
        {
            switch (activity.ToLower())
            {
                case "walking":
                    return 3.8m;  
                case "swimming":
                    return 7.0m;
                case "running":
                    return 9.8m;
                case "cycling":
                    return 7.5m;
                case "jump rope":
                    return 12.0m;
                case "squatting":
                    return 5.0m; 
                case "burpee":
                    return 8.0m;
                case "jumping jack":
                    return 8.0m;
                default:
                    return 0m;
            }
        }
    }
}
