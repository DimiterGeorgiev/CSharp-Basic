using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            double price = 0.00;
            double rent = 0.00;

            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }


                if (n <= 6)
                {
                    price = rent - rent * 0.1;
                }
                else if (n >= 7 && n <= 11)
                {
                    price = rent - rent * 0.15;
                }
                else if (n >= 12)
                {
                    price = rent - rent * 0.25;
                }


            if (n % 2 == 0 && season != "Autumn")
            {
                price = price - price * 0.05;
            }

            if (budget >= price)
            {
                double rest = budget - price;
                Console.WriteLine($"Yes! You have {rest:F2} leva left.");
            }
            else if (price > budget)
            {
                double need = price - budget;
                Console.WriteLine($"Not enough money! You need {need:F2} leva.");
            }



        }
    }
}
