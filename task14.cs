using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void Main(string[] Args)
        {
            int i = -10;
            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }


                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine(" FINAL BREAK REACHED! This should not happen!");
        }
    }
}
