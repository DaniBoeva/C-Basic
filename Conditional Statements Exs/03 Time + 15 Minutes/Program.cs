using System;

namespace _03_Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int newMinutes = minute + 15; //59+15 = 74
            int printMinutes = newMinutes - 60; //стават 14 мин

            if (minute >= 45)
            {
                if (printMinutes < 10)
                {
                    if (hour == 23)
                    {
                        Console.WriteLine($"0:0{printMinutes}");
                    }
                    else
                    {
                        Console.WriteLine($"{hour + 1}:0{printMinutes}");
                    }
                }
                else if (hour ==23)
                {
                    Console.WriteLine($"0:{newMinutes - 60}");
                }
                else
                {
                    Console.WriteLine($"{hour+1}:{printMinutes}");
                }
            }
            else
            {
                Console.WriteLine($"{hour}:{newMinutes}");
            }
           
        }
    }
}
