using System;

namespace Cyti_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameProduct = Console.ReadLine();
            string cyti = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            
            if (cyti == "Sofia")
            {
                if (nameProduct == "coffee") price = quantity * 0.50;
                else if (nameProduct == "water") price = quantity * 0.80;
                else if (nameProduct == "beer") price = quantity * 1.20;
                else if (nameProduct == "sweets") price = quantity * 1.45;
                else if (nameProduct == "peanuts") price = quantity * 1.60;
                Console.WriteLine(price);
            }
            else if (cyti == "Plovdiv")
            {
                if (nameProduct == "coffee") price = quantity * 0.40;
                else if (nameProduct == "water") price = quantity * 0.70;
                else if (nameProduct == "beer") price = quantity * 1.15;
                else if (nameProduct == "sweets") price = quantity * 1.30;
                else if (nameProduct == "peanuts") price = quantity * 1.50;
                Console.WriteLine(price);
            }
            else if (cyti == "Varna")
            {
                if (nameProduct == "coffee") price = quantity * 0.45;
                else if (nameProduct == "water") price = quantity * 0.70;
                else if (nameProduct == "beer") price = quantity * 1.10;
                else if (nameProduct == "sweets") price = quantity * 1.35;
                else if (nameProduct == "peanuts") price = quantity * 1.55;
                Console.WriteLine(price);
            }
        }
    }
}
