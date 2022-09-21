using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string favoritBook = Console.ReadLine();
            string nextBook = Console.ReadLine();
            int bookCounter = 0;
            bool surchBook = false;

            while (nextBook != "No More Books")
            {
                if (nextBook == favoritBook)
                {
                    surchBook = true;
                    break;
                                  
                }
                bookCounter++;
                nextBook = Console.ReadLine();
            }
            if (surchBook)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
            
        }
    }
}
