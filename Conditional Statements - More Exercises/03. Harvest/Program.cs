using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int squareM = int.Parse(Console.ReadLine());
            double grapeSqM = double.Parse(Console.ReadLine());
            int needWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double wineLiters = squareM * 0.4 * grapeSqM / 2.5;
            if (wineLiters<needWine)
            {
                var difference = needWine - wineLiters;
                Console.WriteLine($"It will be a tough winter! More { Math.Floor(difference)} liters wine needed.");
            }
            else
            {
                var difference = wineLiters - needWine;
                var wineForPerson = difference / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLiters)} liters.");
                Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling(wineForPerson)} liters per person.");
            }




        }
    }
}
