using System;

namespace _04_Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {




            double exursionPrice = double.Parse(Console.ReadLine());

            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int toysQuantity = puzzels + dolls + bears + minions + trucks;
            double money = puzzels*2.60 + dolls*3.00 + bears*4.10 + minions*8.20 + trucks*2.00;

            if (toysQuantity>=50)
            {
                money = money - money * 0.25;
            }
            money = money -= money * 0.10;
            double difference = exursionPrice - money;

            if (difference<=0)
            {
                Console.WriteLine($"Yes! {Math.Abs(difference):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
        }
    }
}
