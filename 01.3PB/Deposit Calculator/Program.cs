using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());

            double sum = deposit + month * ((deposit * rate/100) / 12);

            Console.WriteLine(sum);

        }
    }
}
