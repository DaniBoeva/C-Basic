using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double sumFlowers = magnolias * 3.25 + hyacinths * 4.00 + roses * 3.50 + cactuses * 8.00;
            double profit = sumFlowers - sumFlowers * 0.05;

            if (profit>=priceGift)
            {
                var difference = profit - priceGift;
                Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
            }
            else
            {
                var difference = priceGift - profit;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
            }
        }
    }
}
