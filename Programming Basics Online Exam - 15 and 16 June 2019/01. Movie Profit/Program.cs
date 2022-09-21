using System;

namespace _01._Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double minutesQuota = double.Parse(Console.ReadLine());
            double secondsQuota = double.Parse(Console.ReadLine());
            double metersRoute = double.Parse(Console.ReadLine());
            double secHundredMeters = double.Parse(Console.ReadLine());

            double timeQuota = minutesQuota * 60 + secondsQuota;
            double delayNum = metersRoute / 120;
            double timeRoute = metersRoute / 100 * secHundredMeters - delayNum*2.5;

            if (timeRoute<=timeQuota)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeRoute:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(timeRoute-timeQuota):f3} second slower.");
            }

        }
    }
}
