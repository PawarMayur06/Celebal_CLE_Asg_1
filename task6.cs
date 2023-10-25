using System;

namespace assignment
{
    public class Program
    {
        public static string LowUpper(string input)
        {
            string lowerCase = input.ToLower();
            string upperCase = input.ToUpper();
            return lowerCase + upperCase;
        }
        public static void Count(string input)
        {
            int count = input.Length;
            Console.WriteLine("The amount of characters is " + count + ".");
        }
        public static void Run()
        {
            string inp = "hey there !";

            string result = LowUpper(inp);
            Console.WriteLine(result);
            Count(inp);
        }

        public static void Main(string[] args)
        {
            Run();
        }
    }
}
