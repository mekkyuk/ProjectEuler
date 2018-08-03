using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver26 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            int longestRun = 0, longestRunDenominator = 0, i = 999;

            while(i > longestRun)
            {
                List<int> remainders = new List<int>();
                int nextDivider = 10, runLength = 0;
                while (true)
                {
                    int remainder = nextDivider % i;
                    if (!remainders.Contains(remainder))
                    {
                        remainders.Add(remainder);
                        nextDivider = remainder * 10;
                        runLength++;
                    }
                    else
                    {
                        if(runLength > longestRun)
                        {
                            longestRun = runLength;
                            longestRunDenominator = i;
                        }
                        break;
                    }
                }

                i--;
            }

            return longestRunDenominator;
        }
    }
}
