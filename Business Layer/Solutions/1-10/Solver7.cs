using System.Numerics;
using Business_Layer.Solutions.Contracts;
using Business_Layer.Helpers;
using System.Collections.Generic;

namespace Business_Layer.Solutions._1_10
{
    public class Solver7 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            int result = 0;
            int primesLimit = 100000;
            while(result == 0)
            {
                BigInteger numberOfPrimes = 0;
                bool[] test = PrimeHelper.FindPrimesUnderLimit(primesLimit);
                for(int i = 0; i < test.Length; i++)
                {
                    if (test[i])
                    {
                        numberOfPrimes++;

                        if(numberOfPrimes == input)
                        {
                            result = i;
                        }
                    }
                }

                primesLimit += 100000;
            }
            return result;
        }
    }
}
