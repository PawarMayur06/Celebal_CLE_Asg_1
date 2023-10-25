using System;

namespace assignment
{
    public class Program
    {
        public static void check(int value)
        {
            if (value % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            }
            else if (value % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            }
            else
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine("Even number.");
                }
                else
                {
                    Console.WriteLine("Odd number.");
                }
            }
        }
        public static void Main(string[] args)
        {
            int testNumber1 = 3;
            int testNumber2 = 28;
            int testNumber3 = 1;

            Console.Write("For number " + testNumber1 + ": ");
            check(testNumber1);

            Console.Write("For number " + testNumber2 + ": ");
            check(testNumber2);

            Console.Write("For number " + testNumber3 + ": ");
            check(testNumber3);
        }
    }
}

