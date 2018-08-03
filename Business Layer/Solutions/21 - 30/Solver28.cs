using Business_Layer.Solutions.Contracts;
using System;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver28 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger sum = 1;
            // n increments by 2 each time
            // top right = n^2
            // top left = n^2 - n + 1
            // bottom left = n^2 - 2n + 2
            // bottom right = n^2 - 3n + 3
            // sum of each new one is 4n^2 -6n + 6

            for (int i = 3; i <= 1001; i += 2)
            {
                sum += 4 * (i * i) - 6 * i + 6;
            }

            return sum;
        }
    }
}
