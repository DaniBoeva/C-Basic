using System;

namespace _07_Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double budjet = double.Parse(Console.ReadLine()); 
            int videoCards = int.Parse(Console.ReadLine()); 
            int cpu = int.Parse(Console.ReadLine()); 
            int ram = int.Parse(Console.ReadLine()); 

            double sum = videoCards * 250 + cpu * (videoCards*250 * 0.35) + ram * (videoCards*250 * 0.1);

            if (videoCards>cpu)
            {
                sum = sum - sum * 0.15;
            }

            double difference = budjet - sum;
            if (difference>=0)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }
        }
    }
}
