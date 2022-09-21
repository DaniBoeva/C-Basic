using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int value;
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                value = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sumEven += value;
                }
                else
                {
                    sumOdd += value;
                }
            }
            if (sumEven==sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven-sumOdd)}");
            }
        }
    }
}
