using System;
using System.Collections.Generic;
using System.Numerics;

namespace Business_Layer.Helpers
{
    public class PrimeFactor
    {
        public static BigInteger FindLargestPrimeFactor(BigInteger primeLimit)
        {
            BigInteger highestPrime = 2;
            BigInteger test = primeLimit;
            BigInteger nextDivisor = highestPrime;

            while (nextDivisor * nextDivisor < primeLimit)
            {
                if (test % nextDivisor == 0)
                {
                    test = test / nextDivisor;
                    highestPrime = nextDivisor;
                }
                else
                {
                    nextDivisor++;
                }
            }

            return highestPrime;
        }

        public BigInteger RhoAlgorithimForFindingPrimeFactor(BigInteger number)
        {
            List<BigInteger> results = new List<BigInteger>() ;
            BigInteger x = 2, y = 2, d = 1;
            results.Add(x);
            while(d == 1)
            {
                x = x * x + 1;
                y = (y * y + 1) * (y * y + 1) + 1;
                d = GreatestCommonDivisorHelper.BinaryGCD(BigInteger.Abs(x - y), number);
            }

            return d;
        }
    }
}
