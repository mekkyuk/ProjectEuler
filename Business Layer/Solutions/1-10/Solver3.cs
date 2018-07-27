using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions._1_10
{
    public class Solver3 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            return PrimeFactor.FindLargestPrimeFactor(input.Value);
        }
    }
}
