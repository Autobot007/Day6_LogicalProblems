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
                Console.WriteLine("Enter the number  \n 1 for Fibbonacci series \n 2 for Perfect Number \n 3 for Prime Number \n 4 for Reverse Number\n 5 for Coupon Number\n 6 for Stopwatch");
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
                    case 3:
                        PrimeNumber.Q2PrimeNumber();
                        Console.WriteLine("");
                        break;
                    case 4:
                        ReverseNumber.Q4reverseNumber();
                        Console.WriteLine("");
                        break;
                    case 5:
                        CouponNumber.Coupon();
                        break;
                    case 6:
                        StopWatch.Timer();
                        break;
                    default:
                        Console.WriteLine("Please Enter Something");
                        break;
                }

            }

           
        }
    }
}   