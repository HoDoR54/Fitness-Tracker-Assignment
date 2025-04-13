using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Models
{
    public class Activity
    {
        private int _activityId;
        private string _activityName;
        private List<Metric> _metrics;

        public Activity(int activityId, string activityName)
        {
            _activityId = activityId;
            _activityName = activityName;
        }

        public int GetActivityId() => _activityId;
        public string GetActivityName() => _activityName;

        public void SetActivityName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                _activityName = newName;
            }
        }
        public List<Metric> GetMetrics()
        {
            return _metrics;
        }
        public void SetMetrics(List<Metric> newMetrics)
        {
            if (newMetrics != null && newMetrics.Count > 0)
            {
                _metrics = newMetrics;
            }
        }
    }
}
