using System;

namespace Trade_Commissiones
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double seals = double.Parse(Console.ReadLine());

            double commission = 0; 

            if (city == "Sofia" || city == "Varna" || city == "Plovdiv" && seals > 0)
            {
                if (city == "Sofia" && seals >= 0 && seals <= 500) commission = seals * 0.05;
                else if (city == "Sofia" && seals > 500 && seals <= 1000) commission = seals * 0.07;
                else if (city == "Sofia" && seals > 1000 && seals <= 10000) commission = seals * 0.08;
                else if (city == "Sofia" && seals > 10000) commission = seals * 0.12;
                else if (city == "Varna" && seals >= 0 && seals <= 500) commission = seals * 0.045;
                else if (city == "Varna" && seals > 500 && seals <= 1000) commission = seals * 0.075;
                else if (city == "Varna" && seals > 1000 && seals <= 10000) commission = seals * 0.10;
                else if (city == "Varna" && seals > 10000) commission = seals * 0.13;
                else if (city == "Plovdiv" && seals >= 0 && seals <= 500) commission = seals * 0.055;
                else if (city == "Plovdiv" && seals > 500 && seals <= 1000) commission = seals * 0.08;
                else if (city == "Plovdiv" && seals > 1000 && seals <= 10000) commission = seals * 0.12;
                else if (city == "Plovdiv" && seals > 10000) commission = seals * 0.145;
                Console.WriteLine("{0:F2}", commission);

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
