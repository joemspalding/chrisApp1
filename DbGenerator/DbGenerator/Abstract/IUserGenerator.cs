using DbGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbGenerator.Abstract
{
    public interface IUserGenerator
    {
        List<User> GetUsers(int userCount, string[] fields);
    }
}
