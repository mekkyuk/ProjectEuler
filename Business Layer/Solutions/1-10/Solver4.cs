using System.Numerics;
using Business_Layer.Solutions.Contracts;
using System;

namespace Business_Layer.Solutions._1_10
{
    public class Solver4 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger maxPallindrome = 0;
            for(int i = 900; i < 999; i++)
            {
                for(int j = 900; j < 999; j++)
                {
                    int result = i * j;
                    if (result > maxPallindrome) {
                        string resultString = result.ToString();
                        char[] resultCharArray = resultString.ToCharArray();
                        Array.Reverse(resultCharArray);
                        string reverseResultString = new string(resultCharArray);
                        if(resultString == reverseResultString)
                        {
                            maxPallindrome = result;
                        }
                    }
                }
            }

            return maxPallindrome;
        }
    }
}
