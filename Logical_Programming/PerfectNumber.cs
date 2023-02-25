using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class PerfectNumber
    {
        public static void Perfect_Number()
        {
            int num = 28;
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("{0} is a perfect number.", num);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number.", num);
            }
        }
    }
}
