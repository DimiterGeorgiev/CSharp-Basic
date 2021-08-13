using System;

namespace units_m_cm_mm
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string unit1 = Console.ReadLine();
            string unit2 = Console.ReadLine();
            string mm = "mm";
            string cm = "cm";
            string m = "m";

            if (unit1 == mm)
            {
                if (unit2 == cm)
                {
                    double result1 = a / 10;
                    Console.WriteLine("{0:F3}", result1);
                }
                else if (unit2 == m)
                {
                    double result1 = a / 1000;
                    Console.WriteLine("{0:F3}", result1);
                }
            }
            else if (unit1 == cm)
            {
                if (unit2 == mm)
                {
                    double result2 = a * 10;
                    Console.WriteLine("{0:F3}", result2);
                }
                else if (unit2 == m)
                {
                    double result2 = a / 100;
                    Console.WriteLine("{0:F3}", result2);
                }
            }
            else if (unit1 == m)
            {
                if (unit2 == cm)
                {
                    double result3 = a * 100;
                    Console.WriteLine("{0:F3}", result3);
                }
                else if (unit2 == mm)
                {
                    double result3 = a * 1000;
                    Console.WriteLine("{0:F3}", result3);
                }
            }
        }
    }
}
