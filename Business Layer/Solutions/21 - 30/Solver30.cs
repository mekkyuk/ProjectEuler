using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver30 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger max = BigInteger.Pow(9, 5) + BigInteger.Pow(9, 5) + BigInteger.Pow(9, 5) + BigInteger.Pow(9, 5) + BigInteger.Pow(9, 5);

            BigInteger result = 0;

            for (BigInteger i = 2; i < max; i++)
            {
                string iString = i.ToString();
                BigInteger total = 0;
                for(int j = 0; j < iString.Length; j++)
                {
                    var digit = BigInteger.Parse(iString[j].ToString());
                    total += BigInteger.Pow(digit, 5);
                }

                if(i == total)
                {
                    result += i;
                }
            }

            return result;
        }
    }
}
