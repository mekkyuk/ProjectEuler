using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions._31___40
{
    public class Solver36 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger result = 0;
            
            for(int i = 1; i < 1000000; i++)
            {
                if (!GeneralOperationsHelper.IsPallindrome(i))
                {
                    continue;
                }

                if(!GeneralOperationsHelper.IsPallindrome(Convert.ToString(i, 2)))
                {
                    continue;
                }

                result += i;
            }

            return result;
        }
    }
}
