using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startNum = 1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(startNum);
                sum += startNum;
                startNum += 2;

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
