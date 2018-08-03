using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Helpers
{
    /// <summary>
    /// Really quite efficient ways of doing big sums
    /// Not particularly general so you'll need to dig in to see what they do and some have a upper limit before they'll start to crunch
    /// </summary>
    public class BigCalculationHelper
    {
        static BigInteger maxNumber = BigInteger.Parse("99999999999999999999999999999999999999999999999999");
        static BigInteger numberTake = BigInteger.Parse("100000000000000000000000000000000000000000000000000");

        public static string GetTheBigSum(List<BigInteger> inputNumbers)
        {
            BigInteger firstNumbers = 0, last50Numbers = 0;
            foreach (BigInteger inputNumber in inputNumbers)
            {
                last50Numbers += inputNumber;
                if (last50Numbers > maxNumber)
                {
                    firstNumbers++;
                    last50Numbers -= numberTake;
                }
            }

            return firstNumbers.ToString() + last50Numbers.ToString();
        }
        
        public static string GetTheBigPowerOf2(BigInteger power)
        {
            BigInteger firstNumbers = 0, last50Numbers = 2;
            for(BigInteger i = 1; i < power; i++)
            {
                last50Numbers *= 2;
                firstNumbers *= 2;
                if(last50Numbers > maxNumber)
                {
                    firstNumbers++;
                    last50Numbers -= numberTake;
                }
            }

            return firstNumbers.ToString() + last50Numbers.ToString();
        }

        /// <summary>
        /// Gets a really big factorial, will start to crunch after number gets over, I dunno 100 digits, could be improved
        /// </summary>
        /// <param name="factorial">The factorial to get</param>
        /// <returns>A string representation of the factorial, too big to be happily returned, treat with caution</returns>
        public static string GetABigFactorial(BigInteger factorial)
        {
            BigInteger firstNumbers = 0, last50Numbers = 1;
            for(BigInteger i = 2; i <= factorial; i++)
            {
                last50Numbers *= i;
                firstNumbers *= i;
                if (last50Numbers > maxNumber)
                {
                    BigInteger divisor = last50Numbers / maxNumber;
                    firstNumbers += divisor;
                    last50Numbers -= divisor * numberTake;
                }
            }

            return firstNumbers.ToString() + last50Numbers.ToString();
        }

        /// <summary>
        /// Get a big fibonacci number, currently just gets the index of the first number with 1000 digits
        /// </summary>
        /// <param name="numberOfDigits">Doesn't do anything!</param>
        /// <returns></returns>
        public static int GetTheBigFibonacciTermByNumberOfDigits(BigInteger numberOfDigits)
        {
            BigInteger[] lastTermChunks = new BigInteger[20], nextTermChunks = new BigInteger[20];
            lastTermChunks[19] = 1;
            nextTermChunks[19] = 1;
            var index = 2;

            while (nextTermChunks[0] < BigInteger.Parse("10000000000000000000000000000000000000000000000000"))
            {
                for(int i = 19; i >= 0; i--)
                {
                    if(nextTermChunks[i] == 0 && lastTermChunks[i] == 0)
                    {
                        break;
                    }

                    BigInteger temp = nextTermChunks[i];
                    nextTermChunks[i] += lastTermChunks[i];
                    lastTermChunks[i] = temp;

                    if(nextTermChunks[i] > maxNumber)
                    {
                        nextTermChunks[i] -= numberTake;
                        lastTermChunks[i - 1] += 1;
                    }
                }

                index++;
            }

            return index;
        }
    }
}
