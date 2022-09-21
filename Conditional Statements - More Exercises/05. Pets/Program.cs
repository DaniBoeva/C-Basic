using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int day = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double sumFood = day * (dogFood + catFood + turtleFood / 1000);
            if (food>=sumFood)
            {
                var difference = food-sumFood;
                Console.WriteLine($"{Math.Floor(difference)} kilos of food left.");
            }
            else
            {
                var difference = sumFood-food;
                Console.WriteLine($"{Math.Ceiling(difference)} more kilos of food are needed.");
            }


        }
    }
}
