using Day6_LogicalProblem;

namespace Day6_LogicalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("++++++++++Welcome to Day6 Problems++++++++++");
            Console.WriteLine("============================================");
           
            while (true)
            {
                Console.WriteLine("Enter \n 1 for Fibbonacci series \n 2 for Perfect Number");
                int enter = Convert.ToInt32(Console.ReadLine());
                switch (enter)
                {
                    case 1:
                        FibbonacciSeries obj = new FibbonacciSeries();
                        obj.PrintFibbonacci();
                        Console.WriteLine("");
                        break;
                    case 2:
                        PerfectNumber.Q2Perfectnumber();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }

            }

            FibbonacciSeries problem1 = new FibbonacciSeries();
            problem1.PrintFibbonacci();
        }
    }
} 

