using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class CouponNumber
    {
        public static void Coupon_Number()
        {
            static int RandomInt(int max)
            {
                Random rand = new Random();
                return rand.Next(max);
            }

            static int CollectCoupons(int n)
            {
                bool[] collected = new bool[n];
                int count = 0;
                int distinct = 0;
                while (distinct < n)
                {
                    int coupon = RandomInt(n);
                    count++;
                    if (!collected[coupon])
                    {
                        collected[coupon] = true;
                        distinct++;
                    }
                }
                return count;
            }

            static void Main(string[] args)
            {
                Console.Write("Enter the number of distinct coupon numbers: " );
                int n = int.Parse(Console.ReadLine());
                int count = CollectCoupons(n);
                Console.WriteLine("Total random numbers needed: {0}", count);
            }
        }
    }
}
