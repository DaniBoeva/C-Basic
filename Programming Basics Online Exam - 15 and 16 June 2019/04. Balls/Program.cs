using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());

            string colorBalls;
            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            int points = 0;
            int otherCount = 0;
            int blackCount = 0;
            for (int i = 1; i <= balls; i++)
            {
                colorBalls = Console.ReadLine();
                if (colorBalls== "red")
                {
                    points += 5;
                    redCount++;
                }
                else if (colorBalls== "orange")
                {
                    points += 10;
                    orangeCount++;
                }
                else if (colorBalls== "yellow")
                {
                    points += 15;
                    yellowCount++;
                }
                else if (colorBalls== "white")
                {
                    points += 20;
                    whiteCount++;
                }
                else if (colorBalls== "black")
                {
                    points /= 2;
                    blackCount++;
                }
                else
                {
                    otherCount++;
                    continue;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCount}");
            Console.WriteLine($"Orange balls: {orangeCount}");
            Console.WriteLine($"Yellow balls: {yellowCount}");
            Console.WriteLine($"White balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {otherCount}");
            Console.WriteLine($"Divides from black balls: {blackCount}");
        }
    }
}
