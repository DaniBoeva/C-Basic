using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int volume = widht * lenght * hight;
            bool isThereSpace = true;
            string boxes;

            while (isThereSpace)
            {
                boxes = Console.ReadLine();
                

                if (boxes== "Done")
                {
                    isThereSpace = false;
                    break;
                }
                volume -= int.Parse(boxes);
                if (volume<=0)
                {
                    isThereSpace = false;
                    break;
                }
            }
            if (volume>0)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}
