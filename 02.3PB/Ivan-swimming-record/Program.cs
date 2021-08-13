using System;

namespace Ivan_swimming_record
{
    class Program
    {
        static void Main(string[] args)
        {
            double rekord = double.Parse(Console.ReadLine());
            double razst = double.Parse(Console.ReadLine());
            double secProM = double.Parse(Console.ReadLine());

            double mal = razst / 15;
            double mal1 = Math.Floor(mal);
            double t2 = mal1 * 12.5;

            double t3 = razst * secProM + t2;

            if (t3<rekord)
            {
                Console.Write("Yes, he succeeded! The new world record is ");
                Console.Write("{0:F2}", t3);
                Console.WriteLine(" seconds.");
            }
            else
            {
                double t4 = t3 - rekord;
                Console.Write("No, he failed! He was ");
                Console.Write("{0:F2}", t4);
                Console.WriteLine(" seconds slower.");
            }

        }
    }
}
