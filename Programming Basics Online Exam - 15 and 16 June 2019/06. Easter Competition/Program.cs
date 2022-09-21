using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEasterBread = int.Parse(Console.ReadLine());
            int maxRating = 0;
            string maxName = string.Empty;

            for (int bread = 1; bread <= numEasterBread; bread++)
            {
                string nameBaker = Console.ReadLine();
                string input = Console.ReadLine();
                int sumRating = 0;

                while (input != "Stop")
                {
                    int rating = int.Parse(input);
                    sumRating += rating;
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{nameBaker} has {sumRating} points.");
                if (sumRating >= maxRating)
                {
                    maxRating = sumRating;
                    maxName = nameBaker;
                    Console.WriteLine($"{nameBaker} is the new number 1!");
                }
            }
            Console.WriteLine($"{maxName} won competition with {maxRating} points!");
        }
    }
}
