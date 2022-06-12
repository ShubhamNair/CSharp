using System;

namespace StringOperation
{
    internal class Operations
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char input1 = Console.ReadLine()[0];
            string reverse = "", empty = "", string2 = input;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine("Reverse String: {0}", reverse);
            empty = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input1)
                {
                    empty += "$";
                }
                else
                {
                    empty += input[i];
                }
            }
            string2 += "Modified";
            Console.WriteLine($"Extracted String: {input.Substring(2)}\nOriginal String: {input}\nReplaced String:{empty}\nModified String: {string2}");
            Console.ReadKey();
        }
    }
}