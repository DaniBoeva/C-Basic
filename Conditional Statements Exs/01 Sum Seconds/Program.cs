using System;

namespace _01_Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int furstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thtidTime = int.Parse(Console.ReadLine());
            int sumTimeSec = furstTime + secondTime + thtidTime;
            int minutes = sumTimeSec / 60;
            int secunds = sumTimeSec % 60;
            if (secunds<10)
            {
                Console.WriteLine($"{minutes}:0{secunds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{secunds}");
            }
        }
    }
}
