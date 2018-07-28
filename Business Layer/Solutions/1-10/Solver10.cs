using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Numerics;

namespace Business_Layer.Solutions._1_10
{
    public class Solver10 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            bool[] primesUnderLimit = PrimeHelper.FindPrimesUnderLimit(2000000);
            BigInteger total = 0;
            for(int i = 0; i < primesUnderLimit.Length; i++)
            {
                if(primesUnderLimit[i])
                {
                    total += i;
                }
            }

            return total;
        }
    }
}
