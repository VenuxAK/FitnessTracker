using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace FitnessTracker
{
    public static class Validator
    {
        public static bool ValidateUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username) &&
                   username.All(c => char.IsLetterOrDigit(c));
        }

        public static bool ValidatePassword(string password)
        {
            return password != null &&
                   password.Length == 12 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower);
        }
    }
}
