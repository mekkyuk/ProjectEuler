﻿using Business_Layer.Solutions.Contracts;
using System;
using System.Numerics;

namespace Business_Layer.Helpers
{
    public class GeneralOperationsHelper
    {
        /// <summary>
        /// For factorials of integers
        /// Note: there is a bigcalculationshelper method for big factorials this is for little 
        /// uns where its more efficient not to do any dickery
        /// </summary>
        /// <param name="input">The number to get the factorial of</param>
        /// <returns>The factorial of the input number</returns>
        public static int Factorial(int input)
        {
            if(input == 0)
            {
                return 1;
            }
            int result = 1;
            while(input != 1)
            {
                result *= input;
                input--;
            }

            return result;
        }

        public static bool IsPallindrome(int input)
        {
            var inputString = input.ToString();

            return IsPallindrome(inputString);
        }

        public static bool IsPallindrome(string inputString)
        {
            for (int i = 0; i < inputString.Length / 2; i++)
            {
                if (inputString[i] != inputString[inputString.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
