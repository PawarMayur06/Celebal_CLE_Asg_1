using System;

namespace assignment
{
    public class Program
    {

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi " + name + ", my friend!");
        }

        public static void Main(string[] args)
        {

            string friend1 = "Harry";
            string friend2 = "Ron";
            string friend3 = "Hermione";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }
    }
}
