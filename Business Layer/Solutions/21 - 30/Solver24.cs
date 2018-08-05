using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver24 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            string start = "0123456789";
            int[] numberSequence = start.Select(x => int.Parse(x.ToString())).ToArray();

            for(int i = 0; i < 999999; i++)
            {
                int kIndex = 8;
                // Step 1
                while(kIndex != -1)
                {
                    if(numberSequence[kIndex] < numberSequence[kIndex + 1])
                    {
                        break;
                    }

                    kIndex--;
                }

                int lIndex = 9; 

                while(lIndex != -1)
                {
                    if(numberSequence[kIndex] < numberSequence[lIndex])
                    {
                        break;
                    }

                    lIndex--;
                }

                int kIndexValue = numberSequence[kIndex];
                numberSequence[kIndex] = numberSequence[lIndex];
                numberSequence[lIndex] = kIndexValue;

                int[] arrayToReverse = new int[10 - kIndex - 1];
                Array.ConstrainedCopy(numberSequence, kIndex + 1, arrayToReverse, 0, 10 - kIndex - 1);
                Array.Reverse(arrayToReverse);
                Array.ConstrainedCopy(arrayToReverse, 0, numberSequence, kIndex + 1, arrayToReverse.Length);
            }

            string result = "";
            foreach (int number in numberSequence)
            {
                result += number.ToString();
            }

            return BigInteger.Parse(result);
        }
    }
}
