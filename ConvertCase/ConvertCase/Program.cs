using System;

namespace ConvertCase
{
    internal class Convert
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i]++;
                if (chars[i] >= 65 && chars[i] <= 90)
                {
                    chars[i] = Char.ToLowerInvariant(chars[i]);
                }
                else if (chars[i] >= 97 && chars[i] <= 122)
                {
                    chars[i] = Char.ToUpperInvariant(chars[i]);
                }
            }
            string output = new string(chars);

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
