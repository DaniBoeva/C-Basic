using System;

namespace _06_World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double recordsSec = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double metSecIv = double.Parse(Console.ReadLine());

            double secIv = meters * metSecIv;
            if (meters>=15)
            {
                double numberOfDelays = Math.Floor(meters / 15);
                secIv = meters*metSecIv+ numberOfDelays*12.5;
            }

            double difference = recordsSec - secIv;
            if (difference>0)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {secIv:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(difference):f2} seconds slower.");
            }
        }
    }
}
