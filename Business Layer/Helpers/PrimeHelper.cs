using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Helpers
{
    public class PrimeHelper
    {
        /// <summary>
        /// This is a sort of sieve of Eratosthenes https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
        /// </summary>
        /// <param name="limit">The number under which to find the primes</param>
        /// <returns>Array where if entry is true then prime, false then not prime. 1 based index, 0 entry is NOTHING</returns>
        public static bool[] FindPrimesUnderLimit(int limit)
        {
            bool[] results = new bool[limit + 1];

            for (int i = 2; i <= limit; i++)
            {
                results[i] = true;
            }

            int primeTest = 2;

            while(primeTest * primeTest < limit)
            {
                ExtractMultiples(limit, results, primeTest);
                for(int i = primeTest + 1; i <= limit; i++)
                {
                    if(results[i] == true)
                    {
                        primeTest = i;
                        break;
                    }
                }
            }

            return results;
        }

        private static void ExtractMultiples(int limit, bool[] results, int primeTest)
        {
            var testNumber = primeTest * 2;
            while (testNumber <= limit)
            {
                results[testNumber] = false;
                testNumber += primeTest;
            }
        }
    }
}
