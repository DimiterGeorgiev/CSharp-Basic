using System;

namespace Operations_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            double sbor = N1 + N2;
            double razlika = N1 - N2;
            double umno = N1 * N2;
            
            

            string evenORodd = " ";

            

            if (oper == "+")
            {
                if (sbor % 2 == 0)
                {
                    evenORodd = "even";
                }
                else if (sbor % 2 != 0)
                {
                    evenORodd = "odd";
                }
                Console.WriteLine($"{N1} + {N2} = {sbor} - {evenORodd}");
            }
            else if (oper == "-")
            {
                if (razlika % 2 == 0)
                {
                    evenORodd = "even";
                }
                else if (razlika % 2 != 0)
                {
                    evenORodd = "odd";
                }
                Console.WriteLine($"{N1} - {N2} = {razlika} - {evenORodd}");
            }
            else if (oper == "*")
            {
                if (umno % 2 == 0)
                {
                    evenORodd = "even";
                }
                else if (umno % 2 != 0)
                {
                    evenORodd = "odd";
                }
                Console.WriteLine($"{N1} * {N2} = {umno} - {evenORodd}");
            }
            else if (oper == "/")
            {
                if (N2 != 0)
                {
                    double N2del = N2;
                    double delenie = N1 / N2del;
                    Console.WriteLine($"{N1} / {N2} = {delenie:F2}");
                }
                else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
            else if (oper == "%")
            {
                if (N2 != 0)
                {
                    int modul = N1 % N2;
                    Console.WriteLine($"{N1} % {N2} = {modul}");
                }
                else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
                
            


            

            



        }
    }
}
