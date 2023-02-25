using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class ReverseNumber
    {
        public static void Reverse_Number()
        {
            int num = 12345;
            int reverse = 0;
            while (num != 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("The reverse of the number is: {0}", reverse);
        }
    }
}
