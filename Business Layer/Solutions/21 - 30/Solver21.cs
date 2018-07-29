using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver21 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger result = 0;
            bool[] primesUnderLimit = PrimeHelper.FindPrimesUnderLimit(10001);
            for (int i = 2; i < 10000; i++)
            {
                if (primesUnderLimit[i])
                {
                    continue;
                }

                BigInteger sumOfDivisors = DivisorsHelper.SumOfDivisors(i, primesUnderLimit) - i;
                if(sumOfDivisors < 10000 && 
                    sumOfDivisors != i  &&
                    DivisorsHelper.SumOfDivisors((int)sumOfDivisors, primesUnderLimit) - sumOfDivisors == i)
                {
                    result += i;
                }
            }
            
            return result;
        }
    }
}
