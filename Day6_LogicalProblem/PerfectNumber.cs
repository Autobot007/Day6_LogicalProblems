using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblem
{
    internal class PerfectNumber
    {

        public static void Q2Perfectnumber()
        {
            int num = Convert.ToInt16(Console.ReadLine());
            int sum = 1;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (i * i != num)
                        sum = sum + i + num / i;
                    else
                        sum = sum + i;
                }

            }
            if (sum == num && num != 1)
                Console.WriteLine("{0} is the Perfect number", num);
            else
                Console.WriteLine("{0} is not a Perfect number", num);



        }
    }
}
 