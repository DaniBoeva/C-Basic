using System;

namespace _03._Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sizeEggs = Console.ReadLine();
            string colorEggs = Console.ReadLine();
            double numOfLots = double.Parse(Console.ReadLine());
            double priceofLots = 0;

            if (sizeEggs=="Large" && colorEggs== "Red")
            {
                priceofLots = 16.00;
            }
            else if (sizeEggs== "Large" && colorEggs== "Green")
            {
                priceofLots = 12.00;
            }
            else if (sizeEggs == "Large" && colorEggs == "Yellow" || sizeEggs == "Medium" && colorEggs == "Green" || sizeEggs == "Small" && colorEggs == "Red")
            {
                priceofLots = 9.00;
            }
            else if (sizeEggs == "Medium" && colorEggs == "Red")
            {
                priceofLots = 13.00;
            }
            else if (sizeEggs == "Medium" && colorEggs == "Yellow")
            {
                priceofLots = 7.00;
            }
            else if (sizeEggs == "Small" && colorEggs == "Green")
            {
                priceofLots = 8.00;
            }
            else if (sizeEggs == "Small" && colorEggs == "Yellow")
            {
                priceofLots = 5.00;
            }
            double endPrice = numOfLots * priceofLots - (numOfLots * priceofLots * 0.35);
            Console.WriteLine($"{endPrice:f2} leva.");
        }
    }
}
