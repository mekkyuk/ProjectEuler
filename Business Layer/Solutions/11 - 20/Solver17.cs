using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions.Solutions_11___20
{
    public class Solver17 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger result = 0;
            for(int i = 1; i <= input; i++)
            {
                if (i > 10 && i < 20)
                {
                    result = TheDiffcultNumbers(result, i);
                    continue;
                }

                if(i == 1000)
                {
                    result += "onethousand".Length;
                    continue;
                }

                var numberString = i.ToString();
                var lastDigit = int.Parse(numberString.Substring(numberString.Length - 1, 1));
                var secondLastDigit = 0;

                if (i >= 10)
                {
                    secondLastDigit = int.Parse(numberString.Substring(numberString.Length - 2, 1));
                }

                if (secondLastDigit != 1)
                {
                    result = IncrementByDigit(result, lastDigit);
                }

                if (i == 10 || i > 19)
                {
                       result = IncrementBySecondToLastDigit(result, secondLastDigit, lastDigit);
                }

                if(i >= 100 && i < 1000)
                {
                    result = IncrementByDigit(result, int.Parse(numberString.Substring(0, 1)));
                    result += "hundred".Length;
                }

                if(i % 100 == 0)
                {
                    continue;
                }
                else if(i > 100)
                {
                    result += "and".Length;
                }
            }

            return result;
        }

        private static BigInteger IncrementByDigit(BigInteger result, int digit)
        {
            switch (digit)
            {
                case 1:
                    result += "one".Length;
                    break;
                case 2:
                    result += "two".Length;
                    break;
                case 3:
                    result += "three".Length;
                    break;
                case 4:
                    result += "four".Length;
                    break;
                case 5:
                    result += "five".Length;
                    break;
                case 6:
                    result += "six".Length;
                    break;
                case 7:
                    result += "seven".Length;
                    break;
                case 8:
                    result += "eight".Length;
                    break;
                case 9:
                    result += "nine".Length;
                    break;
            }

            return result;
        }

        private static BigInteger IncrementBySecondToLastDigit(BigInteger result, int secondLastDigit, int lastDigit)
        { 
            switch (secondLastDigit)
            {
                case 1:
                    result = TheDiffcultNumbers(result, lastDigit + 10);
                    break;
                case 2:
                    result += "twenty".Length;
                    break;
                case 3:
                    result += "thirty".Length;
                    break;
                case 4:
                    result += "forty".Length;
                    break;
                case 5:
                    result += "fifty".Length;
                    break;
                case 6:
                    result += "sixty".Length;
                    break;
                case 7:
                    result += "seventy".Length;
                    break;
                case 8:
                    result += "eighty".Length;
                    break;
                case 9:
                    result += "ninety".Length;
                    break;
            }

            return result;
        }

        private static BigInteger TheDiffcultNumbers(BigInteger result, int i)
        {
            if (i == 10)
            {
                result += "ten".Length;
            }

            if (i == 11)
            {
                result += "eleven".Length;
            }

            if (i == 12)
            {
                result += "twelve".Length;
            }

            if (i == 13)
            {
                result += "thirteen".Length;
            }

            if (i == 14)
            {
                result += "fourteen".Length;
            }

            if (i == 15)
            {
                result += "fifteen".Length;
            }

            if (i == 16)
            {
                result += "sixteen".Length;
            }

            if (i == 17)
            {
                result += "seventeen".Length;
            }

            if (i == 18)
            {
                result += "eighteen".Length;
            }

            if(i == 19)
            {
                result += "nineteen".Length;
            }

            return result;
        }
    }
}
