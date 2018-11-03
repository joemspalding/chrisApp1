using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbGenerator
{
    public class RandomizationHelper
    {
        private string RandomStringHelper(int requestedLength, string range)
        {

            Random rnd = new Random();
            char[] allLetters = range.ToCharArray();
            string randomizedString = "";

            while (randomizedString.Length < requestedLength)
            {
                randomizedString = randomizedString + allLetters[rnd.Next(allLetters.Length)];
            }

            return randomizedString;
        }

        public string GetRandomString (int requestedLength)
        {
            return RandomStringHelper(requestedLength, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }

        public string GetKEYSMASH(int requestedLength)
        {
            return RandomStringHelper(requestedLength, "asdfghjklASDFGHJKL");
        }

        public string GetRandomInt(int requestedLength)
        {
            Random rnd = new Random();
            string randomInt = "";

            while (randomInt.Length < requestedLength)
            {
                randomInt = randomInt + rnd.Next(9);
            }

            return randomInt;
        }



    }
}
