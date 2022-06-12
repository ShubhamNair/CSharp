using System;

namespace Operations
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            int num1 = 1, num2, temp;
            num2 = ++num1;                  //pre-inceementing num1
            Console.WriteLine("Pre-incrementing: {0}", num2);
            num2 = num1++;                  //post-inscreementing num1
            Console.WriteLine("Post-incrementing: {0}", num2);
            //Swapping both values
            Console.WriteLine($"Before Swapping: {num1} and {num2}");
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After swapping: {num1} and {num2}");

        }
    }
}