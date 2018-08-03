using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver25 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            //return BigCalculationHelper.GetTheBigFibonacciTermByNumberOfDigitsTest(3);
            return BigCalculationHelper.GetTheBigFibonacciTermByNumberOfDigits(1000);
        }
    }
}
