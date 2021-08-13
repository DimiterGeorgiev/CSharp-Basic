using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string plod = Console.ReadLine();
            string day = Console.ReadLine();
            double quantaty = double.Parse(Console.ReadLine());

            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday" || day == "Sunday")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    if (plod == "banana" || plod == "apple" || plod == "orange" || plod == "kiwi" || plod == "pineapple" || plod == "grapes")
                    {
                        if (plod == "banana") price = quantaty * 2.50;
                        else if (plod == "apple") price = quantaty * 1.20;
                        else if (plod == "orange") price = quantaty * 0.85;
                        else if (plod == "grapefruit") price = quantaty * 1.45;
                        else if (plod == "kiwi") price = quantaty * 2.70;
                        else if (plod == "pineapple") price = quantaty * 5.50;
                        else if (plod == "grapes") price = quantaty * 3.85;
                        Console.WriteLine("{0:F}", price);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    if (plod == "banana") price = quantaty * 2.70;
                    else if (plod == "apple") price = quantaty * 1.25;
                    else if (plod == "orange") price = quantaty * 0.90;
                    else if (plod == "grapefruit") price = quantaty * 1.60;
                    else if (plod == "kiwi") price = quantaty * 3.00;
                    else if (plod == "pineapple") price = quantaty * 5.60;
                    else if (plod == "grapes") price = quantaty * 4.20;
                    Console.WriteLine("{0:F}", price);
                }
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
