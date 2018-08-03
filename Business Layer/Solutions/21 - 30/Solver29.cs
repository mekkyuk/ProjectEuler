using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver29 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            List<BigInteger> terms = new List<BigInteger>();
            for(int a = 2; a <= 100; a++)
            {
                for(int b = 2; b <=100; b++)
                {
                    var term = BigInteger.Pow(a, b);
                    if (!terms.Contains(term))
                    {
                        terms.Add(term);
                    }
                }
            }

            return terms.Count;
        }
    }
}
