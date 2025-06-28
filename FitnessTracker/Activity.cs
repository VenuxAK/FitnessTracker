using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class Activity
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double DurationHours { get; set; }
        public double MET { get; set; }
        public DateTime Date { get; set; }

        public Activity(string name, double weightKg, double durationHours, double met)
        {
            Name = name;
            Weight = weightKg;
            DurationHours = durationHours;
            MET = met;
            Date = DateTime.Now;
        }

        // Calculates calories burned using MET formula.
        public double CalculateCalories()
        {
            return MET * Weight * DurationHours;
        }
    }
}
