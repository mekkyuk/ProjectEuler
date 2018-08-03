using Business_Layer.Solutions.Contracts;
using System;
using System.Numerics;

namespace Business_Layer.Solutions._31___40
{
    public class Solver31 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            int[] inputs = { 200, 100, 50, 20, 10, 5, 2, 1 };
            BigInteger result = 0;
            
            //begin the shitcodery
            for(int a = 200; a >= 0; a -= 200)
            {
                for(int b = a; b >= 0; b-= 100)
                {
                    for(int c = b; c>=0; c-= 50)
                    {
                        for(int d = c; d>=0; d-=20)
                        {
                            for(int e = d; e >=0; e-=10)
                            {
                                for(int f = e; f >= 0; f-=5)
                                {
                                    for(int g = f; g>=0; g -= 2)
                                    {
                                        result++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
