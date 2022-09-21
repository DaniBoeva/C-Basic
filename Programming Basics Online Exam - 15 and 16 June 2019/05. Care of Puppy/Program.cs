using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string eatFood = Console.ReadLine();
            int infood = input * 1000;
            int food = infood;
            int sumEat = 0;
            while (eatFood != "Adopted")
            {
                int eat = int.Parse(eatFood);
                food -= eat;
                sumEat +=eat;
                eatFood = Console.ReadLine();
            }
            if (food<0)
            {
                Console.WriteLine($"Food is not enough. You need {sumEat-infood} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {food} grams.");
            }
        }
    }
}
