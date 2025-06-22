using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class FitnessTracker
    {
        private List<User> users = new List<User>();
        public User? CurrentUser { get; private set; } // Declare CurrentUser as nullable to fix CS8618

        public FitnessTracker()
        {
            // Initialize with some test users if needed
            users.Add(new User("UserOne", "Userone11111"));
            users.Add(new User("UserTwo", "Usertwo22222"));
            users.Add(new User("UserThree", "Userthree33333"));
            users.Add(new User("UserFour", "Userfour44444"));
            users.Add(new User("UserFive", "Userfive55555"));
        }

        public bool Register(string username, string password)
        {
            // Check if username already exists
            if (users.Any(u => u.Username == username))
                return false;

            users.Add(new User(username, password));
            var user = users.FirstOrDefault(u => u.Username == username);
            CurrentUser = user;
            return true;
        }

        public bool Login(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            CurrentUser = user;
            return user != null;
        }
    }
}
