using System;

namespace _02._NumbersNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            
            for (int number = n; number >= 1; number--)
            {
                Console.WriteLine(number);
            }
        }
    }
}
