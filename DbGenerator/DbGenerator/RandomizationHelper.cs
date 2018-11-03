using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbGenerator
{
    public class RandomizationHelper
    {
        public string GetRandomString (int requestedLength)
        {
            Random rnd = new Random();
            char[] allLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string randomString = ""; 

            while(randomString.Length < requestedLength)
            {
                randomString = randomString + allLetters[rnd.Next(allLetters.Length)];
            }

            return randomString;
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

        public string GetKEYSMASH(int requestedLength)
        {
            Random rnd = new Random();
            char[] allLetters = { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'j', 'k', 'l'};
            string keySmash = "";

            while (keySmash.Length < requestedLength)
            {
                keySmash = keySmash + allLetters[rnd.Next(allLetters.Length)];
            }

            return keySmash;
        }
    }
}
