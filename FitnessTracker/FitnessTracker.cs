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

        // Currently logged-in user
        public User? CurrentUser { get; private set; }

        public FitnessTracker()
        {
            LoadTestUsers(); // preload test user for demo
        }

        public bool Register(string username, string password)
        {
            // Check if username already exists
            if (users.Any(u => u.Username == username))
                return false;

            var newUser = new User(username, password);
            users.Add(newUser);
            CurrentUser = newUser;
            return true;
        }

        // Login an existing user with valid credentials
        public bool Login(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            CurrentUser = user;
            return user != null;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
        
        private void LoadTestUsers()
        {
            users.AddRange(new[]
            {
                new User("UserOne", "Userone11111"),
                new User("UserTwo", "Usertwo22222"),
                new User("UserThree", "Userthree33333"),
                new User("UserFour", "Userfour44444"),
                new User("UserFive", "Userfive55555")
            });
        }
    
    }
}
