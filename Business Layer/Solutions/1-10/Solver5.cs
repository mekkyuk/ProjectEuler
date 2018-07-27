using Business_Layer.Solutions.Contracts;
using System;
using System.Numerics;

namespace Business_Layer.Solutions._1_10
{
    public class Solver5 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger test = 20, result = 20;
            while (test != 1)
            {
                if(result % test == 0)
                {
                    test -= 1;
                }
                else
                {
                    test = 20;
                    result += 20;
                }
            }

            return result;
        }
    }
}
