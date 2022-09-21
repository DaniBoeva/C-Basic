using System;

namespace _08_Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string name = Console.ReadLine();
            int timeEpisode = int.Parse(Console.ReadLine()); 
            int timeBreak = int.Parse(Console.ReadLine());  
                                                            
            double freeTime = timeBreak * 5 / 8.0;

            if (timeEpisode<=freeTime)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(freeTime-timeEpisode)} minutes free time.");
            }
            else
            {

                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeEpisode-freeTime)} more minutes.");
            }

        }
    }
}
