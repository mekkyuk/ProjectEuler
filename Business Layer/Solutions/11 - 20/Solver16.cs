using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions.Solutions_11___20
{
    public class Solver16 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger firstDigits = 0, last50Digits = 0;
            string powerResult = BigCalculationHelper.GetTheBigPowerOf2(input.Value);
            BigInteger result = 0;
            for(int i = 0; i < powerResult.Length; i++)
            {
                result += int.Parse(powerResult[i].ToString());
            }

            return result;
        }
    }
}
