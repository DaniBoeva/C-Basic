using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int sumValue = 0;

            while (sumValue < number)
            {
                int value = int.Parse(Console.ReadLine());
                sumValue += value;
            }
            Console.WriteLine(sumValue);
        }
    }
}
