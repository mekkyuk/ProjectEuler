using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Business_Layer.Solutions._21___30
{
    public class Solver22 : ISolver
    {
        public BigInteger Solve(BigInteger? input = null)
        {
            StreamReader sr = new StreamReader("Solutions\\21 - 30\\22.txt");

            string inputText = sr.ReadLine();
            sr.Close();

            List<string> names = inputText.Split(',').Select(s => s.Replace("\"", "")).ToList();
            names.Sort();
            int index = 1;
            BigInteger result = 0;
            foreach (string name in names)
            {
                int nameTotal = 0;
                for(int i = 0; i < name.Length; i++)
                {
                    nameTotal += (int)name[i] - 64;
                }

                result += index * nameTotal;
                index++;
            }

            return result;
        }
    }
}
