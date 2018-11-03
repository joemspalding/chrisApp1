using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbGenerator;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            UserGenerator dbGenerator = new UserGenerator();

            Console.WriteLine(dbGenerator.GetString());
        }
    }
}
