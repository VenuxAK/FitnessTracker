using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public double CalorieGoal { get; set; }

        public double CalorieBurned {  get; set; }

        //public string GoalStatus { get; set; }

        public List<Activity> Activities { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            CalorieGoal = 0; // Default goal
            CalorieBurned = 0;
            Activities = new List<Activity>();
        }

        public double GetTotalCaloriesBurned()
        {
            return Activities.Sum(activity => activity.CalculateCalories());
        }

        public string GoalStatus()
        {
            return CalorieBurned > CalorieGoal ? "You've achieved your goal!" : "Ongoing!";
        }


    }
}
