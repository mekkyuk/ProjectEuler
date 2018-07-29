using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Helpers
{
    public class DivisorsHelper
    {
        public static Dictionary<int, int> CalculatePrimeDivisors(int testNumber, bool[] primes)
        {
            Dictionary<int, int> divisors = new Dictionary<int, int>();
            int testDivisor = 2; 
            while (true)
            {
                if (testNumber % testDivisor == 0)
                {
                    if (!divisors.ContainsKey(testDivisor))
                    {
                        divisors.Add(testDivisor, 0);
                    }

                    divisors[testDivisor]++;
                    testNumber = testNumber / testDivisor;
                    if (testNumber == 1)
                    { 
                        break;
                    }

                    if (primes[testNumber])
                    {
                        if (!divisors.ContainsKey(testNumber))
                        {
                            divisors.Add(testNumber, 0);
                        }

                        divisors[testNumber]++;
                        break;
                    }
                }
                else
                {
                    for (int k = testDivisor + 1; k < primes.Length; k++)
                    {
                        if (primes[k])
                        {
                            testDivisor = k;
                            break;
                        }
                    }
                }
            }

            return divisors;
        }

        public static BigInteger SumOfDivisors(int input, bool[] primes)
        {
            Dictionary<int, int> divisors = CalculatePrimeDivisors(input, primes);
            BigInteger result = 1;
            foreach (KeyValuePair<int, int> divisorPower in divisors)
            {
                result *= (BigInteger.Pow(divisorPower.Key, divisorPower.Value + 1) - 1) / (divisorPower.Key - 1);
            }

            return result;
        }

        public static BigInteger SumOfProperDivisors(int input, bool[] primes)
        {
            return SumOfDivisors(input, primes) - input;
        }
    }
}
