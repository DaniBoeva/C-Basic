using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double priceExcursion = double.Parse(Console.ReadLine());
            double saveMoney = double.Parse(Console.ReadLine());

            int dayCounter = 0;
            int daySpentCounter = 0;

            while (saveMoney<priceExcursion)
            {
                string dayOptions = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                dayCounter++;

                if (dayOptions== "spend")
                {
                    daySpentCounter++;
                    
                    
                    if (daySpentCounter==5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{dayCounter}");
                        break;
                    }
                    
                    saveMoney -= money;
                    if (saveMoney<0)
                    {
                        saveMoney = 0;
                    }

                }
                else // (dayOptions== "save")
                {
                    saveMoney += money;
                    daySpentCounter=0;
                }
                
            }
            if (saveMoney>=priceExcursion)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }
        }
    }
}
