using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Business_Layer.Solutions.Solutions_11___20
{
    public class Solver12 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            int numberOfDivisors = 0;
            int i = 2, triangleNumber = 1;
            
            while(numberOfDivisors < 500)
            {
                numberOfDivisors = 0;
                triangleNumber += i;

                int testNumber = triangleNumber;
                Dictionary<int, int> divisors = DivisorsHelper.CalculatePrimeDivisors(testNumber, PrimeHelper.FindPrimesUnderLimit(200000000));

                numberOfDivisors = divisors.Values.ElementAt(0) + 1;
                for (int l = 1; l < divisors.Count; l++)
                {
                    numberOfDivisors *= divisors.Values.ElementAt(l) + 1;
                }

                i++;
            }


            return triangleNumber;
        }
    }
}
