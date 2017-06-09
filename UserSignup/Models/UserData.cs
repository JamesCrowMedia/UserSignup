using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        static private List<User> users = new List<User>();

        public static List<User> GetAll()
        {
            return users;
        }

        public static void Add(User newUser)
        {
            users.Add(newUser);
        }

        public static void Remove(int userId)
        {
            users.RemoveAll(x => x.UserId.Equals(userId));
        }

        public static User GetById(int userId)
        {
            return users.Single(x => x.UserId == userId);
        }
    }
}
