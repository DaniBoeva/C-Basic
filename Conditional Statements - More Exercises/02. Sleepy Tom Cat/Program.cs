using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dayOff = int.Parse(Console.ReadLine());
            int norm = 30000;

            int workingDay = 365 - dayOff;
            int playTime = workingDay * 63 + dayOff * 127;

            if (playTime>norm)
            {
                int difference = playTime - norm;
                int hours = difference / 60;
                int minutes = difference % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                int difference = norm - playTime;
                int hours = difference / 60;
                int minutes = difference % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }



        }
    }
}
