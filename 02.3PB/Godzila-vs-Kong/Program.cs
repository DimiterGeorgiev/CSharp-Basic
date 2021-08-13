using System;

namespace Godzila_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budge = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double priceDress = double.Parse(Console.ReadLine());

            double decor = budge * 0.1;

            double dressAllactor = actors * priceDress;

            if (actors < 150)
            {
                dressAllactor = 1 * dressAllactor;
            }
            else
            {
                dressAllactor = 0.9 * dressAllactor;
            }

            double razhod = decor + dressAllactor;

            if (budge >= razhod)
            {
                double rest = budge - razhod;
                Console.WriteLine("Action!");
                Console.Write($"Wingard starts filming with ");
                Console.Write("{0:F2}", rest);
                Console.WriteLine(" leva left.");
            }
            else if (budge <= razhod)
            {
                double nedostig = razhod - budge;
                Console.WriteLine("Not enough money!");
                Console.Write($"Wingard needs ");
                Console.Write("{0:F2}", nedostig);
                Console.WriteLine(" leva more.");
            }
                

        }
    }
}
