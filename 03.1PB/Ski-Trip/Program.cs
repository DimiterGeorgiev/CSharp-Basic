using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typ = Console.ReadLine();
            string note = Console.ReadLine();

            double price = 0;
            int night = days - 1;

            if (typ == "room for one person")
            {
                if (note == "positive") price = night * 18 * 1.25;
                else if (note == "negative") price = night * 18 * 0.9;
            }
            else if (typ == "apartment" && days < 10)
            {
                if (note == "positive") price = night * 25 * 0.7 * 1.25;
                else if (note == "negative") price = night * 25 * 0.7 * 0.9;
            }
            else if (typ == "apartment" && days <= 15)
            {
                if (note == "positive") price = night * 25 * 0.65 * 1.25;
                else if (note == "negative") price = night * 25 * 0.65 * 0.9;
            }
            else if (typ == "apartment" && days > 15)
            {
                if (note == "positive") price = night * 25 * 0.5 * 1.25;
                else if (note == "negative") price = night * 25 * 0.5 * 0.9;
            }
            else if (typ == "president apartment" && days < 10)
            {
                if (note == "positive") price = night * 35 * 0.9 * 1.25;
                else if (note == "negative") price = night * 35 * 0.9 * 0.9;
            }
            else if (typ == "president apartment" && days <= 15)
            {
                if (note == "positive") price = night * 35 * 0.85 * 1.25;
                else if (note == "negative") price = night * 35 * 0.85 * 0.9;
            }
            else if (typ == "president apartment" && days > 15)
            {
                if (note == "positive") price = night * 35 * 0.8 * 1.25;
                else if (note == "negative") price = night * 35 * 0.8 * 0.9;
            }
            Console.WriteLine("{0:F2}", price);
        }
    }
}
