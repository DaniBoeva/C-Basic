using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n=int.Parse(Console.ReadLine());
            int a;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                a= int.Parse(Console.ReadLine());
                leftSum += a;
            }
            for (int i = 1; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());
                rightSum += a;
            }

            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        
        }
    }
}
