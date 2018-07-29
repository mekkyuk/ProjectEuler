using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions.Solutions_11___20
{
    public class Solver14 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger result = 0, highestFunction = 0;
            for(int i = 2; i < 1000000; i++)
            {
                BigInteger functionLength = 0, testNumber = i;
                while(testNumber != 1)
                {
                    if (testNumber % 2 == 0)
                    {
                        testNumber = evenFunction(testNumber);
                    }
                    else
                    {
                        testNumber = oddFunction(testNumber);
                    }

                    functionLength++;
                }

                if(functionLength > highestFunction)
                {
                    result = i;
                    highestFunction = functionLength;
                }
            }

            return result;
        }

        public BigInteger evenFunction(BigInteger input)
        {
            return input / 2;
        }

        public BigInteger oddFunction(BigInteger input)
        {
            return 3 * input + 1;
        }
    }
}
