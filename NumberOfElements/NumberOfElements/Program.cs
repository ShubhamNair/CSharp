using System;

namespace NumberOfElements
{
    internal class Elements
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}