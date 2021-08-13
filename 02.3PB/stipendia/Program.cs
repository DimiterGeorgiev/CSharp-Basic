using System;

namespace stipendia
{
    class Program
    {
        static void Main(string[] args)
        {
            double dochod = double.Parse(Console.ReadLine());
            double uspeh = double.Parse(Console.ReadLine());
            double zaplata = double.Parse(Console.ReadLine());

            double socStip = zaplata * 0.35;
            double uspStip = uspeh * 25;

            double RoundsocStip = Math.Floor(socStip);
            double RounduspStip = Math.Floor(uspStip);

            if (uspeh < 4.5)
            {
                Console.WriteLine("You cannot get a scholarship");
            }
            else if (uspeh < 5.5)
            {
                if (dochod < zaplata)
                {
                    Console.WriteLine($"You get a Social scholarship {RoundsocStip} BGN");
                }
                else
                {
                    Console.WriteLine($"You cannot get a scholarship!");
                }
            }
            else if (uspeh >= 5.5)
            {
                if (dochod > zaplata)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {RounduspStip} BGN");
                }
                else if (dochod < zaplata)
                {
                    if (uspStip >= socStip)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {RounduspStip} BGN");
                    }
                    else if (uspStip < socStip)
                    {
                        Console.WriteLine($"You get a Social scholarship {RoundsocStip} BGN");
                    }
                }
            }
        }
    }
}
