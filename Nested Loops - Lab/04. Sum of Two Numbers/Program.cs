using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magigNum = int.Parse(Console.ReadLine());
            int count = 0;
            bool isMagic = false;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    count++;
                    if (i+j ==magigNum)
                    {
                        isMagic = true;
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magigNum})");
                        break;
                    }
                    
                }
                if (isMagic)
                {
                    break;
                }
            }
            if (!isMagic)
            {
                Console.WriteLine($"{count} combinations - neither equals {magigNum}");
            }


        }
    }
}
