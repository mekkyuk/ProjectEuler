using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace Business_Layer.Solutions._31___40
{
    public class Solver32 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            List<BigInteger> results = new List<BigInteger>();
            for (int i = 2; i < 100; i++)
            {
                // i has repeating characters!
                if (i.ToString().Contains("0") || i.ToString().GroupBy(x => x).Any(g => g.Count() > 1))
                {
                    continue;
                }

                for(int j = 1; j < 9999; j++)
                {
                    // j has repeating characters!
                    if(j.ToString().Contains("0") || j.ToString().GroupBy(x => x).Any(g => g.Count() > 1))
                    {
                        continue;
                    }

                    // i or j contains one of the other!
                    if (i.ToString().Any(x => j.ToString().Contains(x)) || j.ToString().Any(x => i.ToString().Contains(x)))
                    {
                        continue;
                    }

                    var product = i * j;

                    // product has repeating characters!
                    if (product.ToString().Contains("0") || product.ToString().GroupBy(x => x).Any(g => g.Count() > 1))
                    {
                        continue;
                    }

                    if(product.ToString().Any(x => i.ToString().Contains(x) || j.ToString().Contains(x)))
                    {
                        continue;
                    }

                    if ("123456789".Any(x => !product.ToString().Contains(x) && !i.ToString().Contains(x) && !j.ToString().Contains(x)))
                    {
                        continue;
                    }

                    if (!results.Contains(product))
                    {
                        results.Add(product);
                    }
                }
            }

            return results.Sum(x => (int)x);
        }
    }
}
