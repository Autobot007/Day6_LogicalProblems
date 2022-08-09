using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day6_LogicalProblem
{
    public class PrimeNumber
    {
        public static void Q2PrimeNumber()
        {
            Console.WriteLine("Please Enter Number");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = 0;

            for(int i = 2; i <= num-1; i++)
            {
                if (num % i == 0)
                   temp++;
                
            }
            if (temp == 0)
                Console.WriteLine("{0} is a Prime Number", num);
            else 
                Console.WriteLine("{0} is not a Prime Number",num);
            Console.WriteLine("");


        }
    }
}


