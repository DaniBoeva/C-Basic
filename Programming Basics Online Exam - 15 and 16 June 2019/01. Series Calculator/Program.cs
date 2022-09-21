using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            double numOfSeason = double.Parse(Console.ReadLine());
            double numOfEpisodes = double.Parse(Console.ReadLine());
            double timeOfEpisod = double.Parse(Console.ReadLine());

            //? time every episodes Of serial --> advertisements-20% Of episodTime ---> SpecialEpisod +10min
            // time = rounded to the lower number ---> "Total time needed to watch the {име на сериал} series is {време} minutes."

            double timeEpisodAdver = timeOfEpisod + timeOfEpisod * 0.2;
            double sumTime = numOfSeason*(numOfEpisodes * timeEpisodAdver + 10);
            Console.WriteLine($"Total time needed to watch the {nameSerial} series is {Math.Floor(sumTime)} minutes.");
        }
    }
}
