using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions.Solutions_11___20
{
    public class Solver19 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            BigInteger result = 0;
            DateTime testDate = new DateTime(1901, 1, 1);

            while(testDate <= new DateTime(2000, 12, 31))
            {
                if (testDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    result++;
                }

                testDate = testDate.AddMonths(1);
            }

            return result;
        }
    }
}
