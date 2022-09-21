using System;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string typeFuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();
        
            if (typeFuel== "Gas")
            {

                if (liters > 25)
                {

                    if (card == "Yes")
                    {
                        double price = 0.85;
                        double fuel = liters * price- liters * price*0.10;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                    else
                    {
                        double price = 0.93;
                        double fuel = liters * price - liters * price * 0.10;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                }
                else if (liters < 20)
                {
                    if (card == "Yes")
                    {
                        double price = 0.85;
                        double fuel = liters * price;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                    else
                    {
                        double price = 0.93;
                        double fuel = liters * price;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                }
                else //между 20 и 25 л
                {
                    if (card == "Yes")
                    {
                        double price = 0.85;
                        double fuel = liters * price- liters * price*0.08;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                    else
                    {
                        double price = 0.93;
                        double fuel = liters * price - liters * price * 0.08;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                }
            }
            else if (typeFuel == "Gasoline")
            {
                if (liters > 25)
                {

                    if (card == "Yes")
                    {
                        double price =2.04;
                        double fuel = liters * price - liters * price * 0.10;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                    else
                    {
                        double price = 2.22;
                        double fuel = liters * price - liters * price * 0.10;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                }
                else if (liters < 20)
                {
                    if (card == "Yes")
                    {
                        double price = 2.04;
                        double fuel = liters * price;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                    else
                    {
                        double price = 2.22;
                        double fuel = liters * price;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                }
                else //между 20 и 25 л
                {
                    if (card == "Yes")
                    {
                        double price = 2.04;
                        double fuel = liters * price - liters * price * 0.08;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                    else
                    {
                        double price = 2.22;
                        double fuel = liters * price - liters * price * 0.08;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                }
            }
            else if (typeFuel== "Diesel")
            {
                if (liters > 25)
                {

                    if (card == "Yes")
                    {
                        double price = 2.21;
                        double fuel = liters * price-(liters * price*0.10);
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                    else
                    {
                        double price = 2.21;
                        double fuel = liters * price - (liters * price * 0.10);
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                }
                else if (liters < 20)
                {
                    if (card == "Yes")
                    {
                        double price = 2.21;
                        double fuel = liters * price;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                    else
                    {
                        double price = 2.33;
                        double fuel = liters * price;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                }
                else //между 20 и 25 л
                {
                    if (card == "Yes")
                    {
                        double price = 2.21;
                        double fuel = liters * price- liters * price*0.08;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                    else
                    {
                        double price = 2.33;
                        double fuel = liters * price-liters* price*0.08;
                        Console.WriteLine($"{fuel:f2} lv.");
                    }
                }
            }
        }
    }
}
