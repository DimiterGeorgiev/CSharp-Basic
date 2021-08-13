using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceFlower = 0.0;
            double rest = 0.0;
            double need = 0.0;

            if (flower == "Roses")
            {
                if (n > 80)
                {
                    priceFlower = n * 5.00 * 0.9;
                }
                else if (n <= 80)
                {
                    priceFlower = n * 5.00;
                }
            }
            else if (flower == "Dahlias")
            {
                if (n > 90)
                {
                    priceFlower = n * 3.80 * 0.85;
                }
                else if (n <= 90)
                {
                    priceFlower = n * 3.80;
                }
            }
            else if (flower == "Tulips")
            {
                if (n > 80)
                {
                    priceFlower = n * 2.80 * 0.85;
                }
                else if (n <= 80)
                {
                    priceFlower = n * 2.80;
                }
            }
            else if (flower == "Narcissus")
            {
                if (n < 120)
                {
                    priceFlower = n * 3.00 * 1.15;
                }
                else if (n >= 120)
                {
                    priceFlower = n * 3.00;
                }
            }
            else if (flower == "Gladiolus")
            {
                if (n < 80)
                {
                    priceFlower = n * 2.50 * 1.2;
                }
                else if (n >= 80)
                {
                    priceFlower = n * 2.50;
                }
            }

            if (budget >= priceFlower)
            {
                rest = budget - priceFlower;

                Console.WriteLine($"Hey, you have a great garden with {n} {flower} and {rest:F2} leva left.");
            }
            else if (budget < priceFlower)
            {
                need = priceFlower - budget;

                Console.WriteLine($"Not enough money, you need {need:F2} leva more.");
            }
        }
    }
}
