using System.Numerics;
using Business_Layer.Solutions.Contracts;

namespace Business_Layer.Solutions._1_10
{
    public class Solver6 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger sumOfSquares = 0;
            for(int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
            }

            BigInteger squareOfSums = 0;
            int total = 0;
            for(int i = 1; i <= 100; i++)
            {
                total += i;
            }

            squareOfSums = total * total;

            return squareOfSums - sumOfSquares;
        }
    }
}
