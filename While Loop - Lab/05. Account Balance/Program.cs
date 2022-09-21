using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double deposit = 0.00;
            double sumDeposit = 0;

            while (input != "NoMoreMoney")
            {
                deposit = double.Parse(input);
                
                if (deposit<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                Console.WriteLine($"Increase: {deposit:f2}");
                sumDeposit += deposit;
                input = Console.ReadLine();

            }
            Console.WriteLine($"Total: {sumDeposit:f2}");
        }
    }
}
