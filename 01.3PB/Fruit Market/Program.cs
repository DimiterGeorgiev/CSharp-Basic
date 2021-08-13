using System;

namespace Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double PriceBerries = double.Parse(Console.ReadLine());
            double KgBannane = double.Parse(Console.ReadLine());
            double KgOrange = double.Parse(Console.ReadLine());
            double KgRaspberries = double.Parse(Console.ReadLine());
            double KgBarries = double.Parse(Console.ReadLine());

            double PriceRaspberries = PriceBerries / 2;
            double PriceOrange = PriceRaspberries - PriceRaspberries * 0.4;
            double PriceBannane = PriceRaspberries - PriceRaspberries * 0.8;

            double money = KgBarries * PriceBerries + KgRaspberries * PriceRaspberries + KgOrange * PriceOrange + KgBannane * PriceBannane;

            Console.WriteLine("{0:F2}", money);
        }
    }
}
