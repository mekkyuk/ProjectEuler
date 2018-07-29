using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions.Solutions_11___20
{
    public class Solver20 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger result = 0;
            string factorialResult = BigCalculationHelper.GetABigFactorial(input.Value);
            for(int i = 0; i < factorialResult.Length; i++)
            {
                result += int.Parse(factorialResult[i].ToString());
            }

            return result;
        }
    }
}
