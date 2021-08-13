using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double Prosent = double.Parse(Console.ReadLine());

            double volume = l * b * h;

            double volumeLiter = volume / 1000;

            double volumeLiterWater = volumeLiter - volumeLiter * Prosent/100;

            Console.WriteLine(volumeLiterWater);

        }
    }
}
