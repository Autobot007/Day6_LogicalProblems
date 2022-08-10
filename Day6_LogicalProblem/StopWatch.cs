using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblem
{
    internal class StopWatch
    {
        public static void Timer()
        {
            Console.WriteLine("Press Enter to Start stopwatch");
            Console.ReadLine();
            DateTime start = DateTime.Now;

            Console.WriteLine("Press Enter to Start stopwatch");
            Console.ReadLine();
            DateTime stop = DateTime.Now;

            Console.WriteLine("Elapsed Time =" + (stop - start));
        }

    }
}