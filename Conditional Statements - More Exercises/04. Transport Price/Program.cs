using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kilometers = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            if (kilometers>=100)
            {
                double price = kilometers * 0.06;
                Console.WriteLine($"{price:f2}");
            }
            else if (kilometers>=20)
            {
                double price = kilometers * 0.09;
                Console.WriteLine($"{price:f2}");
            }
            else
            {
                if (partOfDay=="day")
                {
                    double price = 0.70+kilometers * 0.79;
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    double price = 0.70 + kilometers * 0.90;
                    Console.WriteLine($"{price:f2}");
                }
            }

        }
    }
}
