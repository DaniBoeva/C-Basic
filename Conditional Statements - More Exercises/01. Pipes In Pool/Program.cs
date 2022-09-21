using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int litersPool = int.Parse(Console.ReadLine());
            int furstTipeLitH = int.Parse(Console.ReadLine()); 
            int secondTipeLitH = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double sumLitH = (furstTipeLitH + secondTipeLitH) * hours;
            if (sumLitH<litersPool)
            {
                double persentageOfPool = sumLitH/ litersPool*100;
                double persentageFurstTipe = furstTipeLitH * hours / sumLitH * 100;
                double persentageSecondTipe = secondTipeLitH*hours/sumLitH*100;
                Console.WriteLine($"The pool is {persentageOfPool:f2}% full. Pipe 1: {persentageFurstTipe:f2}%. Pipe 2: {persentageSecondTipe:f2}%.");
            }
            else
            {
                double overflow = sumLitH - litersPool;
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {overflow:f2} liters.");
            }



        }
    }
}
