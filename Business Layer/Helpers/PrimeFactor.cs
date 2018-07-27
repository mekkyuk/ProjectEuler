using System.Numerics;

namespace Business_Layer.Helpers
{
    public class PrimeFactor
    {
        public static BigInteger FindLargestPrimeFactor(BigInteger primeLimit)
        {
            BigInteger highestPrime = 2;
            BigInteger test = primeLimit;
            BigInteger nextDivisor = highestPrime;

            while (nextDivisor * nextDivisor < primeLimit)
            {
                if (test % nextDivisor == 0)
                {
                    test = test / nextDivisor;
                    highestPrime = nextDivisor;
                }
                else
                {
                    nextDivisor++;
                }
            }

            return highestPrime;
        }
    }
}
