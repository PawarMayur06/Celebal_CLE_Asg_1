using System;

namespace assignment
{
    public class strings
    {
        public static void Main(string[] args)
        {

            string inp;
            string upper;
            string lower;
            string nospace;
            string sub;

            Console.WriteLine("Please enter your name and press enter: ");
            inp = Console.ReadLine();
            upper = inp.ToUpper();
            lower = inp.ToLower();
            nospace = inp.Replace(" ", "");
            sub = inp.Substring(1);


            Console.WriteLine("Uppercase: " + upper);
            Console.WriteLine("Lowercase: " + lower);
            Console.WriteLine("String with no spaces: " + nospace);
            Console.WriteLine("Substring: " + sub);
        }
    }
}
