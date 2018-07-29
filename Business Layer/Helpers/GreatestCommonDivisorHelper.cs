using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Helpers
{
    public class GreatestCommonDivisorHelper
    {
        public static BigInteger BinaryGCD(BigInteger firstInput, BigInteger secondInput)
        {
            int d = 0;
            while(firstInput % 2 == 0 && secondInput % 2 == 0)
            {
                firstInput = firstInput / 2;
                secondInput = secondInput / 2;
                d = d + 1;
            }

            while (firstInput != secondInput)
            {
                if (firstInput % 2 == 0)
                {
                    firstInput = firstInput / 2;
                }
                else if (secondInput % 2 == 0)
                {
                    secondInput = secondInput / 2;
                }
                else if (firstInput > secondInput)
                {
                    firstInput = (firstInput - secondInput) / 2;
                }
                else
                {
                    secondInput = (secondInput - firstInput) / 2;
                }
            }

            return firstInput * BigInteger.Pow(2, d);
        }
    }
}
