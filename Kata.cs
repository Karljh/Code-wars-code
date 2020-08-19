using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace NUnitTestProject1
{
    class Kata
    {
        public static int Find(int[] integers)
        {
            var oddList = new List<int>();
            var evenList = new List<int>();

            foreach (var N in integers)
            { 
                if (N % 2 != 0)
                {
                    oddList.Add(N);
                }
                else
                {
                    evenList.Add(N);
                }
            }

            if(oddList.Count > 1)
            {
                return evenList[0];
            }

            else
            {
                return oddList[0];
            }
        }
    }
}
