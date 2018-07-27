using Business_Layer.Solutions.Contracts;
using System.Numerics;

namespace Business_Layer.Solutions._1_10
{
    /// <summary>
    /// Lowest common multiple under 1000 sum stuff
    /// </summary>
    public class Solver1 : ISolver
    {
        public BigInteger Solve(BigInteger? upperBound = null)
        {
            var sum = 0;
            for(int i = 3; i <= upperBound; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
