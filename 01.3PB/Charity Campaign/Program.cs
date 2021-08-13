using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int cook = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int waffels = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());

            double cakeDayMoney = cake * 45;
            double waffelsDayMoney = waffels * 5.8;
            double pancakeDayMoney = pancake * 3.2;

            double DayMoney = (cakeDayMoney + waffelsDayMoney + pancakeDayMoney) * cook;

            double AllMoney = DayMoney * day;

            double profit = AllMoney - AllMoney / 8;

            Console.WriteLine(profit);
        }
    }
}
