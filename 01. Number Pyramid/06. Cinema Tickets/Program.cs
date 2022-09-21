using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;


            string filmName = Console.ReadLine();


            while (filmName != "Finish")
            {
                int free = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                int tickets = 0;

                while (type != "End")
                {
                    if (type == "student")
                    {
                        studentTickets++;
                    }
                    else if (type == "standard")
                    {
                        standardTickets++;
                    }
                    else 
                    {
                        kidTickets++;
                    }
                    tickets++;

                    if (tickets == free)
                    {
                        break;
                    }

                    type = Console.ReadLine();
                }

                double occupancy = tickets * 100.0 / free;
                Console.WriteLine($"{filmName} - {occupancy:f2}% full.");

                filmName = Console.ReadLine();
            }

            int totalTickets = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");

            Console.WriteLine($"{studentTickets * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{standardTickets * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 100.0 / totalTickets:f2}% kids tickets.");

        }
    }
}
