using System;

namespace assignment
{

    public class Program
    {
        public static void Check(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        public static void Main(string[] args)
        {
            int a = 7;
            int b = 10;

            Console.WriteLine("Checking number " + a + ":");
            Check(a);

            Console.WriteLine("Checking number " + b + ":");
            Check(b);
        }
    }
}
