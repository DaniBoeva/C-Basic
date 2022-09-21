using System;

namespace _05_Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double budjet = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());
            
            double decor = budjet * 0.10;

            double priceClothing = extras * clothing;
            if (extras>150)
            {
                priceClothing = priceClothing - priceClothing * 0.10;
            }

            double difference = budjet - decor - priceClothing;
            if (difference<0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
        }
    }
}
