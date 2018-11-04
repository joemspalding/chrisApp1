using System.Collections.Generic;
using DbGenerator.Abstract;
using DbGenerator.Concrete;
using DbGenerator.Models;

namespace DbGenerator
{
    public class UserGenerator: IUserGenerator
    {
        public List<User> GetUsers(int userCount, string[] fields)
        {
            List<User> users = new List<User>();
            User user = new User();
            IFactory factory = new Factory();

            foreach(var field in fields)
            {
                user = factory.GetFieldStrategy(field).GenerateField(user);
            }

            users.Add(user);
            
            // TODO: Prevent duplicate users

            return users;
        }

    }
}
