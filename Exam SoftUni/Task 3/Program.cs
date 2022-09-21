using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double price;

            if (place== "Bulgaria")
            {
                price = dancers * points;
                if (season== "summer")
                {
                    price -= price * 0.05;
                }
                else
                {
                    price -= price * 0.08;
                }
            }
            else
            {
                price= dancers * points+(dancers * points)*0.50;
                if (season == "summer")
                {
                    price -= price*0.10;
                }
                else
                {
                    price -= price * 0.15;
                }
            }
            double charity = price * 0.75;
            double endPrice = price - charity;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {(endPrice/dancers):f2}");
            
        }
    }
}
