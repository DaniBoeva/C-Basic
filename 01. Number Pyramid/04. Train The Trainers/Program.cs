using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOfJury = double.Parse(Console.ReadLine());

            double raiting = 0;
            int presentationCount = 0;
            double averageSumRaiting = 0;

            string nameOfPresentation = Console.ReadLine();

            while (nameOfPresentation != "Finish")
            {
                presentationCount++;
                raiting = 0;
                for (int i = 1; i <= numOfJury; i++)
                {
                    raiting += double.Parse(Console.ReadLine());

                }
                raiting /= numOfJury;
                averageSumRaiting += raiting;
                Console.WriteLine($"{nameOfPresentation} - {raiting:f2}.");

                nameOfPresentation = Console.ReadLine();
            }
            averageSumRaiting /= presentationCount;
            Console.WriteLine($"Student's final assessment is {averageSumRaiting:f2}.");

        }
    }
}
