using System;

namespace Vacation_booka_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int sites = int.Parse(Console.ReadLine());
            double siteProHour = double.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            double Hour = sites / siteProHour;

            double HourProDay = Hour / day;

            Console.WriteLine(HourProDay);
        }
    }
}
