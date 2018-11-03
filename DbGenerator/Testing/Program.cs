using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbGenerator;
using DbGenerator.Abstract;
using DbGenerator.Concrete;
using DbGenerator.Models;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            IFactory factory = new Factory();

            user = factory.GetFieldStrategy("Joe").GenerateField(user);

            Console.WriteLine(user.LastName);
        }
    }
}
