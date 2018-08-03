using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Numerics;

namespace Business_Layer.Solutions._31___40
{
    public class Solver35 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            bool[] primesUnderAMillion = PrimeHelper.FindPrimesUnderLimit(1000000);
            BigInteger result = 0;
            for(int i = 2; i < 1000000; i++)
            {
                var testNumber = i;
                var circular = true;
                var testString = testNumber.ToString();

                for (int j = 0; j <= i.ToString().Length + 1; j++)
                {
                    if (!primesUnderAMillion[testNumber] || testNumber > 1000000)
                    {
                        circular = false;
                        break;
                    }
                   
                    testString = testString.Insert(testString.Length, testString.Substring(0, 1));
                    testString = testString.Remove(0, 1);
                    testNumber = int.Parse(testString);
                }

                if (circular)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
