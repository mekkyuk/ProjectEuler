using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions.Solutions_11___20
{
    public class Solver18 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            string inputString = @"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

            string[] rows = inputString.Split(new[] { "\r\n" }, StringSplitOptions.None);
            int[,] triangle = new int[15, 15];
            for (int y = 0; y < rows.Length; y++)
            {
                string[] numberStrings = rows[y].Split(' ');
                for (int x = 0; x < numberStrings.Length; x++)
                {
                    triangle[x, y] = int.Parse(numberStrings[x]);
                }
            }

            int[,] triangleResults = new int[15, 15];

            for(int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 15; j++)
                {
                    triangleResults[i, j] = triangle[i, j];
                }
            }

            for(int y = 14; y > 0; y--)
            {
                int x = 0; 
                while(x < 14 && triangleResults[x + 1, y] != 0)
                {
                    int firstPathSum = triangleResults[x, y] + triangle[x, y - 1];
                    int secondPathSum = triangleResults[x + 1, y] + triangle[x, y - 1];

                    triangleResults[x, y - 1] = firstPathSum >= secondPathSum ? firstPathSum : secondPathSum;
                    x++;
                }
            }

            BigInteger result = 0;

            return triangleResults[0,0];
        }
    }
}
