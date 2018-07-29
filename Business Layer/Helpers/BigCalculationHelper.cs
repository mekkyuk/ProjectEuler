using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Helpers
{
    public class BigCalculationHelper
    {
        static BigInteger maxNumber = BigInteger.Parse("99999999999999999999999999999999999999999999999999");
        static BigInteger numberTake = BigInteger.Parse("100000000000000000000000000000000000000000000000000");

        public static string GetTheBigSum(List<BigInteger> inputNumbers)
        {
            BigInteger firstNumbers = 0, last50Numbers = 0;
            foreach (BigInteger inputNumber in inputNumbers)
            {
                last50Numbers += inputNumber;
                if (last50Numbers > maxNumber)
                {
                    firstNumbers++;
                    last50Numbers -= numberTake;
                }
            }

            return firstNumbers.ToString() + last50Numbers.ToString();
        }
        
        public static string GetTheBigPowerOf2(BigInteger power)
        {
            BigInteger firstNumbers = 0, last50Numbers = 2;
            for(BigInteger i = 1; i < power; i++)
            {
                last50Numbers *= 2;
                firstNumbers *= 2;
                if(last50Numbers > maxNumber)
                {
                    firstNumbers++;
                    last50Numbers -= numberTake;
                }
            }

            return firstNumbers.ToString() + last50Numbers.ToString();
        }

        public static string GetABigFactorial(BigInteger factorial)
        {
            BigInteger firstNumbers = 0, last50Numbers = 1;
            for(BigInteger i = 2; i <= factorial; i++)
            {
                last50Numbers *= i;
                firstNumbers *= i;
                if (last50Numbers > maxNumber)
                {
                    BigInteger divisor = last50Numbers / maxNumber;
                    firstNumbers += divisor;
                    last50Numbers -= divisor * numberTake;
                }
            }

            return firstNumbers.ToString() + last50Numbers.ToString();
        }
    }
}
