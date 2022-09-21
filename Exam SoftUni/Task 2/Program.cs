using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOff = int.Parse(Console.ReadLine());
            double foodKg = double.Parse(Console.ReadLine());
            double foodFurstKg = double.Parse(Console.ReadLine());
            double foodSecondKg = double.Parse(Console.ReadLine());
            double foodTrithKg = double.Parse(Console.ReadLine());

            double needFood = dayOff*(foodFurstKg+foodSecondKg+foodTrithKg);
            if (needFood<=foodKg)
            {
                Console.WriteLine($"{Math.Floor(foodKg-needFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(needFood-foodKg)} more kilos of food are needed.");
            }
        }
    }
}
