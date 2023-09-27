using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalClassification_POE_Part1.Classes
{
    public  class RandomGenerator
    {
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Coding Droplets
        /// URL: https://www.youtube.com/watch?v=Zql7tz5Pzfg
        /// Use: The method is used to generate random numbers and characters which are put together as a single string.
        /// </summary>
        /// <param name="randomNr"></param>
        /// <returns></returns>
        public string RandomNumGenetrator(Random randomNr)
        {
            List<string> generateRandom = new List<string>();
            Random rand = new Random();

            int stringLength = 3;
            string randomString = null;

            var randomInt = randomNr.Next(99, 1000);
            var randomDigit = randomNr.Next(0, 99);

            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var generateString = new string(Enumerable.Repeat(allowedChars, stringLength)
                .Select(a => a[randomNr.Next(a.Length)]).ToArray());

            randomString = randomInt + "." + randomDigit + " " + generateString;
            generateRandom.Add(randomString);


            return randomString;

        }
    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------