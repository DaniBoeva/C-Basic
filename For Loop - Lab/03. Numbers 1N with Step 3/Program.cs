using System;

namespace _03._Numbers_1N_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number+=3)
            {
                Console.WriteLine(number);
            }
        }
    }
}
