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
            var primes = PrimeHelper.FindPrimesUnderLimit(28124);
            List<int> abundantNumbers = new List<int>();
            for (int i = 2; i < 28124; i++)
            {
                if(DivisorsHelper.SumOfProperDivisors(i, primes) > i)
                {
                    abundantNumbers.Add(i);
                }
            }

            BigInteger result = 0;
            bool[] canBeSummed = new bool[28124];
            for(int i = 0; i < abundantNumbers.Count; i++)
            {
                for (int j = 0; j < abundantNumbers.Count; j++)
                {
                    if(abundantNumbers[i] + abundantNumbers[j] >= 28124)
                    {
                        break;
                    }

                    canBeSummed[abundantNumbers[i] + abundantNumbers[j]] = true;
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
