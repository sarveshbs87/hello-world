using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
{
    internal class UnderstandingStatic
    {
        public int c, d;
        public static int Add(int a, int b)
        {
            //int c = 10;
            return a + b;
            //return c + d;

        }

        static void Main(string[] args)
        {
            //UnderstandingStatic.c = 25;
        }
    }
}
