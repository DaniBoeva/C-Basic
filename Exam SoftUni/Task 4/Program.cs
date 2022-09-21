using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            double sumLiters = 0;
            double sumDegreese = 0;

            for (int i = 1; i <= day; i++)
            {
                double liters = double.Parse(Console.ReadLine());
                double degreese = double.Parse(Console.ReadLine());
                sumLiters += liters;
                sumDegreese += liters*degreese;

            }
            double averageDegreese = sumDegreese / sumLiters;
            Console.WriteLine($"Liter: {sumLiters:f2}");
            Console.WriteLine($"Degrees: {averageDegreese:f2}");
            if (averageDegreese<38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegreese>=38 && averageDegreese <=42)
            {
                Console.WriteLine("Super!");
            }
            else if (averageDegreese>42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
