using System;

namespace time_after_15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int m1 = m + 15;
            int m2 = m1 % 60;
            int h1 = m1 / 60;
            int h2 = h + h1;

            if (h!=23)
            {
                if (m2 < 10)
                    Console.WriteLine($"{h2}:0{m2}");
                else
                    Console.WriteLine($"{h2}:{m2}");
            }
            else if (h == 23 && m >= 45)
            {
                h2 = 0;
                if (m2 < 10)
                    Console.WriteLine($"{h2}:0{m2}");
                else
                    Console.WriteLine($"{h2}:{m2}");
            }
            else if (h == 23 && m < 45)
            {
                if (m2 < 10)
                    Console.WriteLine($"{h2}:0{m2}");
                else
                    Console.WriteLine($"{h2}:{m2}");
            }
            
        }
    }
}
