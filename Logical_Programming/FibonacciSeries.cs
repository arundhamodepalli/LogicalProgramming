using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class FibonacciSeries
    {
        public static void Fibonacci_Series()
        {
            int n = 10; 
            int firstTerm = 0, secondTerm = 1, nextTerm;

            Console.WriteLine(" Enter the maximum value in Fibonacci Series:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(firstTerm + "  ");

                nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }

            Console.ReadLine();
        }
    }
}
