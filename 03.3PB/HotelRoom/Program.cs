using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());


                double priceStudio = 0.00;
                double priceApartment = 0.00;



                switch (month)
                {
                    case "May":
                    case "October":
                        {
                            if (n < 7)
                            {
                                priceStudio = 50 * n;
                                priceApartment = 65 * n;
                            }
                            if (n <= 14)
                            {
                                priceStudio = 50 * n * 0.95;
                                priceApartment = 65 * n;
                            }
                            else if (n > 14)
                            {
                                priceStudio = 50 * n * 0.70;
                                priceApartment = 65 * n * 0.9;
                            }
                        }
                        break;
                    case "June":
                    case "September":
                        {
                            priceStudio = 75.20 * n;
                            priceApartment = 68.70 * n;

                            if (n > 14)
                            {
                                priceStudio = 75.20 * n * 0.80;
                                priceApartment = 68.70 * n * 0.9;
                            }
                        }
                        break;
                    case "July":
                    case "August":
                        {
                            priceStudio = 76 * n;
                            priceApartment = 77 * n;

                            if (n > 14)
                            {
                                priceApartment = 77 * n * 0.90;
                            }
                        }
                        break;

                }

                Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                Console.WriteLine($"Studio: {priceStudio:F2} lv.");


        }
    }
}
