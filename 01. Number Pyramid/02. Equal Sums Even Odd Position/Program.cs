﻿using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j <= 5; j++)
                {
                    if (j % 2 ==0)
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum += currentNum[j];
                    }
                }
                if (oddSum==evenSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}