using System;

namespace assignment
{


    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter a string here: ");
            string inp = Console.ReadLine();

            Console.Write("Enter the character to search: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine("Index of character is " + inp.IndexOf(c));

            Console.Write("Enter your first name: ");
            string fn = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string ln = Console.ReadLine();

            Console.WriteLine("Full name is " + fn + " " + ln);
        }
    }
}
