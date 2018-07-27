using System.Numerics;

namespace Business_Layer.Solutions.Contracts
{
    public interface ISolver
    {
        BigInteger Solve(BigInteger? input = null);
    }
}
