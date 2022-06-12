using System;

namespace ArrayOperation
{

    internal class Actions
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter The Numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            // Descending Order
            Array.Sort(numbers);
            Console.WriteLine("Elements In Descending order");
            for (int i = (numbers.Length - 1); i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
            // Minimum and Maximum
            int min = numbers[0];
            int max = numbers[numbers.Length - 1];
            Console.WriteLine($"\nMaximum Value: {max}\nMinimum Value: {min}");

            //Sum of All Elements
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum of All Elements: {sum}");
        }
    }
}
