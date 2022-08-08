using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblem
{
    internal class FibbonacciSeries
    {
        int firstNumber = 0;
        int secondNumber = 1;
        int result;

        public void PrintFibbonacci()
        {
            Console.WriteLine("Enter number to fibbonacci series");
            int number = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("{0}", firstNumber);
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
        }
    
    }
}


