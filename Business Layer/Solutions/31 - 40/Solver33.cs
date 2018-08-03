using Business_Layer.Helpers;
using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Business_Layer.Solutions._31___40
{
    public class Solver33 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger result = 1;
            List<Tuple<BigInteger, BigInteger>> fractions = new List<Tuple<BigInteger, BigInteger>>();
            for(double i = 11; i < 99; i++)
            {
                if(i % 10 == 0)
                {
                    continue;
                }

                for (double j = i + 1; j < 99; j++)
                {
                    if (i.ToString().Substring(1) != j.ToString().Substring(0, 1))
                    {
                        continue;
                    }

                    double fraction = i / j;
                    double reducedI = double.Parse(i.ToString().Substring(0, 1)), reducedJ = double.Parse(j.ToString().Substring(1));
                    double reducedFraction = reducedI / reducedJ;

                    if(reducedFraction == fraction)
                    {
                        fractions.Add(new Tuple<BigInteger, BigInteger>((BigInteger)i, (BigInteger)j));
                    }
                }
            }

            BigInteger greatestDivisor = 0, numerator = 1, denominator = 1;
            foreach (var fraction in fractions)
            {
                numerator *= fraction.Item1;
                denominator *= fraction.Item2;
            }

            while (greatestDivisor != 1)
            {
                greatestDivisor = GreatestCommonDivisorHelper.BinaryGCD(numerator, denominator);
                numerator /= greatestDivisor;
                denominator /= greatestDivisor;
            }
            return denominator;
        }
    }
}
