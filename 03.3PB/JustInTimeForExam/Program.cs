using System;

namespace JustInTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine());
            int mExam = int.Parse(Console.ReadLine());
            int hComming = int.Parse(Console.ReadLine());
            int mComming = int.Parse(Console.ReadLine());


            int fullMinutesExam = hExam * 60 + mExam;
            int fullMinutesComming = hComming * 60 + mComming;




            if (fullMinutesComming == fullMinutesExam)
            {
                Console.WriteLine("On Time");
            }
            else if (fullMinutesComming <= fullMinutesExam && fullMinutesComming >= fullMinutesExam - 30)
            {
                int early = fullMinutesExam - fullMinutesComming;
                Console.WriteLine("On Time");
                Console.WriteLine($"{early} minutes before the start");
            }
            else if (fullMinutesComming < fullMinutesExam - 30)
            {
                int early = fullMinutesExam - fullMinutesComming;
                if (early < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{early} minutes before the start");
                }
                else if (early >= 60)
                {
                    int hEarly = early / 60;
                    int mEarly = early % 60;

                    if (mEarly < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hEarly}:0{mEarly} hours before the start");
                    }
                    else if (mEarly >= 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hEarly}:{mEarly} hours before the start");
                    }
                }
            }
            else if (fullMinutesComming > fullMinutesExam)
            {
                int late = fullMinutesComming - fullMinutesExam;
                if (late < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{late} minutes after the start");
                }
                else if (late >= 60)
                {
                    int hLate = late / 60;
                    int mLate = late % 60;

                    if (mLate < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hLate}:0{mLate} hours after the start");
                    }
                    else if (mLate >= 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hLate}:{mLate} hours after the start");
                    }
                }
            }
        }
    }
}
