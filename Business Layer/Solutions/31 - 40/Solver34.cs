using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Numerics;

namespace Business_Layer.Solutions._31___40
{
    public class Solver34 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            int factorial9 = GeneralOperationsHelper.Factorial(9);
            BigInteger result = 0;
            for (int i = 3; i < 7 * factorial9; i++)
            {
                int factorialSum = 0;
                var iString = i.ToString();
                for(int j = 0; j < iString.Length; j++)
                {
                    factorialSum += GeneralOperationsHelper.Factorial(int.Parse(iString[j].ToString()));
                }

                if(factorialSum == i)
                {
                    result += i;
                }
            }

            return result;
        }
    }
}
