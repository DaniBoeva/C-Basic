using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string typeFuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());

            if (typeFuel == "Diesel")
            {
                if (liters>=25)
                {
                    Console.WriteLine($"You have enough diesel.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with diesel!");
                }

            }
            else if (typeFuel == "Gasoline")
            {
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gasoline!");
                }

            }
            else if (typeFuel == "Gas")
            {
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough gas.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
