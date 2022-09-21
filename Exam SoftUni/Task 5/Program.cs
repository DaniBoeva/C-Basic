using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seaExcursion = int.Parse(Console.ReadLine());
            int mountainExcursion = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int seaCount = seaExcursion;
            int mountainCount = mountainExcursion;
            double seaProfit = 0;
            double mountainProfit = 0;

            while (input != "Stop")
            {
                if (input== "sea")
                {
                    seaProfit += 680.00;
                    seaCount--;
                    if (seaCount < 0)
                    {
                        seaProfit -= 680;
                    }   
                    
                }
                else if (input== "mountain")
                {
                    mountainProfit += 499.00;
                    mountainCount--;
                    if (mountainCount < 0)
                    {
                        mountainProfit -= 499;
                    }
                    
                }
                input = Console.ReadLine();
                if (seaCount<=0 && mountainCount<=0)
                {
                    break;
                }
            }
            if (seaCount<=0 && mountainCount<=0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {seaProfit + mountainProfit} leva.");
        }
    }
}
