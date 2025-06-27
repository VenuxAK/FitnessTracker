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

        public double CalculateCalories()
        {
            return MET * Weight * DurationHours;
        }
    }

    //class Walking : Activity
    //{
    //    public int Steps { get; set; }
    //    public double Distance { get; set; }
    //    public double Time { get; set; }

    //    public override double CalculateCalories()
    //    {
    //        //throw new NotImplementedException();
    //        return (Steps * 0.04) + (Distance * 0.3) + (Time * 4.5);
    //    }
    //}
}
