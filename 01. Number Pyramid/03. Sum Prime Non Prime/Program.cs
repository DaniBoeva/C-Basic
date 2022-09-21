using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int sumSimple = 0;
            int sumNotSim = 0;
            int number;

            while (input != "stop")
            {
                number = int.Parse(input);
                if (number<0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                bool isPrime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number%i==0)
                    {
                        isPrime=false;
                        break;
                    }

                }
                if (isPrime)
                {
                    sumSimple+=number;
                }
                else
                {
                    sumNotSim +=number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumSimple}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNotSim}");
        }
    }
}
