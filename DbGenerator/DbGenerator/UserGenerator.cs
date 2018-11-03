using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbGenerator.Models;
namespace DbGenerator
{
    public class UserGenerator
    {
        public List<User> GetUsers(int userCount)
        {
            List<User> users = new List<User>();

            // TODO: Prevent duplicate users
            return users;
        }

        public string GetString()
        {
            return "I'm in user generator!";
        }
    }
}
