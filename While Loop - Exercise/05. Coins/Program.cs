using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int pieceOfCake = widht * lenght;
            bool isThereCake = true;
            string pieces;

            while (isThereCake)
            {
                pieces = Console.ReadLine();
               

                if (pieces== "STOP")
                {
                    isThereCake = false;
                    break;
                }
                pieceOfCake -= int.Parse(pieces);
                if (pieceOfCake<0)
                {
                    isThereCake = false;
                    break;
                }
            }
            if (pieceOfCake >= 0)
            {
                Console.WriteLine($"{pieceOfCake} pieces are left.");

            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieceOfCake)} pieces more.");
            }
        }
    }
}
