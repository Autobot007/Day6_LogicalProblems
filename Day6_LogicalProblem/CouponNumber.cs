using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblem
{
    internal class CouponNumber
    {

        public static void Coupon()
        {
            Console.WriteLine("Enter the number of distinct coupons needed:");
            int number = Convert.ToInt32(Console.ReadLine());


            int[] coupon = new int[number];
            Random random = new Random();
            int generate = 0;
            int i = 0;
            while(i<number)
            {
                int randomNumber =random.Next(0,number+1);
                generate++;
                Console.WriteLine("Random number is : {0}",randomNumber);
                if (coupon.Contains(randomNumber))
                    continue;
                else
                    coupon[i]=randomNumber;
                
                i++;

            }

            foreach(int coupons in coupon)
            {
                Console.WriteLine(coupon + "");

            }
            Console.WriteLine();
        }
    }
}
