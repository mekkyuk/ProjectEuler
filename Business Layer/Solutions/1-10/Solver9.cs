using Business_Layer.Solutions.Contracts;
using System;

using System.Numerics;

namespace Business_Layer.Solutions._1_10
{
    public class Solver9 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            for(int a = 2; a < 500; a++)
            {
                for(int b = a + 1; b < 500; b++)
                {
                    for(int c = b + 1; c < 750; c++)
                    {
                        if(a + b + c == 1000)
                        {
                            if(a * a + b * b == c * c)
                            {
                                return a * b * c;
                            }
                        }
                    }
                }
            }

            return 0;
        }
    }
}
