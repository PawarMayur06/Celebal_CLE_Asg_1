using System;

namespace assignment
{
    class asg
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85";
            float a = float.Parse(stringForFloat);

            string stringForInt = "12345";
            int b = int.Parse(stringForInt);

            Console.WriteLine("Recently parsed float value is : " + a);
            Console.WriteLine("Recently parsed integer value is : " + b);


        }
    }
}
