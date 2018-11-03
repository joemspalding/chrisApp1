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
            RandomizationHelper stringRandomizer = new RandomizationHelper();

            Console.WriteLine(dbGenerator.GetString());
            Console.WriteLine(stringRandomizer.GetRandomString(5));
            Console.WriteLine(stringRandomizer.GetRandomInt(5));
            Console.WriteLine(stringRandomizer.GetKEYSMASH(25));
        }
    }
}
