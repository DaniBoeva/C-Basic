using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int furstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirthNum = int.Parse(Console.ReadLine());

            for (int i = 2; i <= furstNum; i++)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    for (int k = 2; k <= thirthNum; k++)
                    {
                        if (i%2==0 && (j==2 || j==3 || j==5 || j==7) && k%2==0)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
