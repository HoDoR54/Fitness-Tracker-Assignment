using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Models
{
    public class Metric
    {
        private int _metricId;
        private string _metricName;
        private string _metricUnit;

        public Metric(int metricId, string metricName, string metricUnit)
        {
            _metricId = metricId;
            _metricName = metricName;
            _metricUnit = metricUnit;
        }
        public int GetMetricId() => _metricId;
        public string GetMetricName() => _metricName;
        public string GetMetricUnit() => _metricUnit;
    }
}
