using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver23 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            var primes = PrimeHelper.FindPrimesUnderLimit(30000);
            bool[] abundantNumbers = new bool[28124];
            for (int i = 2; i < 28124 / 2; i++)
            {
                if(DivisorsHelper.SumOfProperDivisors(i, primes)> i)
                {
                    abundantNumbers[i] = true;
                }
            }

            BigInteger result = 0;
            bool[] canBeSummed = new bool[28124];
            for(int i = 1; i < 28124; i++)
            {
                if (!abundantNumbers[i])
                {
                    continue;
                }

                for (int j = 1; i + j < 28124; j++)
                {
                    if (!abundantNumbers[j])
                    {
                        continue;
                    }

                    canBeSummed[i + j] = true;
                }
            }

            for (int i = 1; i < 28124; i++)
            {
                if (!canBeSummed[i])
                {
                    result += i;
                }
            }

            return result;
        }
    }
}
