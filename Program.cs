using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSquareOfOddSeries
{          
    internal class Program
    {
        static int n = 1; static int square=1;
        static void Main(string[] args)
        {
            PrintSquare(11);
        }
       public static void PrintSquare(int limit)
        {
            if (n <= limit)
            {
                Console.WriteLine(square);
                n = n + 2;
                square = n * n;
                PrintSquare(limit);
            }
        }
    }
}
