﻿using System;
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
        public List<Activity> Activities { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            CalorieGoal = 0; // Default goal
            Activities = new List<Activity>();
        }

        public double GetTotalCaloriesBurned()
        {
            return Activities.Sum(activity => activity.CalculateCalories());
        }

        // Returns the status of the user's goal based on calories burned.
        public string GoalStatus()
        {
            double burned = GetTotalCaloriesBurned();
            return CalorieGoal > 0 && burned >= CalorieGoal
                ? "You've achieved your goal!"
                : "Goal in progress...";
        }


    }
}
