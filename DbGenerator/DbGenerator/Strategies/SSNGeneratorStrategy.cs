using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbGenerator.Models;

namespace DbGenerator.Strategies
{
    public class SSNGeneratorStrategy : IFieldGeneratorStrategy
    {
        public User GenerateField(User user)
        {
            user.SSN = "TempString";

            return user;
        }
    }
}
