using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePoint.chef
{
    public class chef_user
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "Chef";

        public chef_user(int userID, string fullName, string email, string password)
        {
            UserID = userID;
            FullName = fullName;
            Email = email;
            Password = password;
        }

        public chef_user() { }
    }
}
