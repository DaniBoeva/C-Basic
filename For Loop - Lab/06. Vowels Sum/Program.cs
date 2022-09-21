using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string text = Console.ReadLine();

           
            int sum = 0;

           
            for (int position = 0; position < text.Length; position++)
            {
                char symbol = text[position];
                switch (symbol)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
