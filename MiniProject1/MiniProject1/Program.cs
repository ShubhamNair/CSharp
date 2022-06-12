using System;
using System.Collections.Generic;

public class UserMainCode
{
    public int[] primeEncoder(int[] input1, int input2)
    {
        int primeCount = 0;
        for (int i = 2; i <= 10000; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i != j && i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primeCount++;
            }
            if (primeCount == input2)
            {
                for (int item = 0; item < input1.Length; item++)
                {
                    input1[item] += i;
                }
                return input1;
            }
        }
        throw new NotImplementedException("Method primeEncoder(int[] input1,int input2) not Implemented.");
    }
}