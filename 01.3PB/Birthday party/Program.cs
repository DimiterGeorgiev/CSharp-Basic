using System;

namespace Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = rent * 0.2;

            double drink = cake - cake * 0.45;

            double animator = rent / 3;

            double money = rent + cake + drink + animator;

            Console.WriteLine(money);
        }
    }
}
