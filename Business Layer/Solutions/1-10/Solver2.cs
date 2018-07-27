using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Solutions._1_10
{
    public class Solver2 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger sum = 0;
            BigInteger previousTerm = 1;
            BigInteger term = 2;
            while(term < input)
            {
                if(term % 2 == 0)
                {
                    sum += term;
                }

                var previousTermHolder = term;
                term += previousTerm;
                previousTerm = previousTermHolder;
            }

            return sum;
        }
    }
}
