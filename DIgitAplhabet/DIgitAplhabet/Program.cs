using System;

namespace DigitAlphabet
{
    internal class Find
    {
        static void Main(string[] args)
        {
            int countDigit = 0, countAlpha = 0;
            string str;
            str = Console.ReadLine();
            char[] z = str.ToCharArray();

            for (int i = 0; i < z.Length; i++)
            {
                if ((z[i] >= 65 && z[i] <= 90) || (z[i] >= 97 && z[i] <= 122))
                {
                    countAlpha++;
                }
                else if (z[i] >= 48 && z[i] <= 57)
                {
                    countDigit++;
                }
            }
            Console.WriteLine("Number of Digits: {0}\nNumber of Alphabets: {1}", countDigit, countAlpha);
            Console.ReadKey();


        }
    }
}