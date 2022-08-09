using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblem
{
    internal class ReverseNumber
    {
        public static void Q4reverseNumber()
        {
            Console.WriteLine("Enter the number");
            int number =Convert.ToInt16(Console.ReadLine());

            int reverse = 0;
            
            while (number != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + number % 10;
                number = number / 10;
            }
            Console.WriteLine("Revese of entered number is = {0}", reverse);

        }
    }
}
