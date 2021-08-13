using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double price = 0.00;
            string type = "";

            if (season == "summer")
            {
                type = "Camp";
            }
            else if (season == "winter")
            {
                type = "Hotel";
            }


            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.3;
                }
                else if (season == "winter")
                {
                    price = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.4;
                }
                else if (season == "winter")
                {
                    price = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                price = budget * 0.9;
            }

            if (destination == "Europe")
            {
                type = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {price:F2}");


        }
    }
}
