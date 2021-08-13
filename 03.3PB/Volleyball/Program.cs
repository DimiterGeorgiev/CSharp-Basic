using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string NormalOrLeap = Console.ReadLine().ToLower(); //Високосна ли е годината
            int p = int.Parse(Console.ReadLine()); // брой празници в годината (не събота и неделя)
            int h = int.Parse(Console.ReadLine()); // брой уикенди с пътуване до родният град

            int SofiaWeekends = 48 - h;
            double PlaySofia = SofiaWeekends * 3.0 / 4.0 + p * 2.0 / 3.0;
            double PlayAll = PlaySofia + h;

            if (NormalOrLeap == "leap")
            {
                PlayAll = PlayAll + PlayAll * 15 / 100.0;
            }

            Console.WriteLine(Math.Floor(PlayAll));


        }
    }
}
