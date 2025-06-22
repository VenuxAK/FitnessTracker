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

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            CalorieGoal = 0; // Default goal
        }
    }
}
