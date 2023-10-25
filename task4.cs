using System;

namespace assignment
{

    public class Program
    {
        public static void Main(string[] args)
        {

            int a = 123;
            double b = 3.142;
            char c = 'A';
            bool d = true;

            string y = "I control text";
            string z = "123";

            Console.WriteLine("Integer Variable: " + a);
            Console.WriteLine("Double Variable: " + b);
            Console.WriteLine("Char Variable: " + c);
            Console.WriteLine("Boolean Variable: " + d);
            Console.WriteLine("String 1: " + y);
            Console.WriteLine("String 2 parsed into int " + int.Parse(z));

        }
    }
}
