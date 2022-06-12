using System;

namespace PlaceValue
{

    internal class Place
    {
        static void Main(string[] args)
        {
            int num1, num2, remainder, count = 1;
            Console.WriteLine("Enter the num1 and num2:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            while (num1 != 0)
            {
                remainder = num1 % 10;
                num1 /= 10;
                if (remainder == num2)
                {
                    break;
                }
                else
                {
                    count *= 10;
                }
            }
            switch (count)
            {
                case 1:
                    Console.WriteLine($"{num2} is at unit's place.");
                    break;

                case 10:
                    Console.WriteLine($"{num2} is at ten's place.");
                    break;

                case 100:
                    Console.WriteLine($"{num2} is at Hundred's place.");
                    break;

                case 1000:
                    Console.WriteLine($"{num2} is at Thousnad's place.");
                    break;

                default:
                    Console.WriteLine($"{num2} is out of range.");
                    break;
            }
        }
    }
}
