using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver27 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            // b must be prime for the case when n = 0; -- this must make it easier, 
            // b + a + 1 must be prime -- does this? IT TURNS OUT IT DOES, as long as b isn't 2 a must be odd
            // n^2 + an + b = p
            var primesUnder2Million = PrimeHelper.FindPrimesUnderLimit(2000000);
            int highestIndex = 39, bestABProduct = 41;
            
            // skip even version of a, hope a isn't 2
            for(int a = -999; a < 1000; a+=2)
            {
                int b = 3;
                while (b < 1000)
                {
                    // b has to be prime!
                    if (primesUnder2Million[b])
                    {
                        int i = 0;
                        // iterate to see how deep the rabbit hole goes for this combination of a and b
                        while(i * i + a * i + b > 0 && primesUnder2Million[i * i + a * i + b])
                        {
                            i++;
                        }

                        // we have a highestindex
                        if(i > highestIndex)
                        {
                            highestIndex = i;
                            bestABProduct = a * b;
                        }
                    }

                    b++;
                }
            }

            return bestABProduct;
        }
    }
}
