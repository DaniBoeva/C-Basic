using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int night = int.Parse(Console.ReadLine());
            int transportCard = int.Parse(Console.ReadLine());
            int ticketMuseum = int.Parse(Console.ReadLine());

            double sumNightPerPerson = night*20.00;
            double sumTransportCardPerPerson = transportCard*1.60;
            double sumTicketMuseumPerPerson = ticketMuseum * 6.00;
            double sumPerPerson = sumNightPerPerson + sumTicketMuseumPerPerson + sumTransportCardPerPerson;
            double sumOfGroup = people * sumPerPerson;
            sumOfGroup +=sumOfGroup*0.25;

            Console.WriteLine($"{sumOfGroup:f2}");


        }
    }
}
