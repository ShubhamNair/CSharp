using System;

namespace Square
{
    internal class Area
    {
        static void Main(string[] args)
        {
            int Side, Area;
            Console.WriteLine("Enter the length of side:");
            Side = Convert.ToInt32(Console.ReadLine());
            Area = Side * Side;
            Console.WriteLine("Area of Square: {0}", Area);
            Console.ReadKey();
        }
    }
}