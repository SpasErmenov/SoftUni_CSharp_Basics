using System;

namespace T08_On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourPristigane = int.Parse(Console.ReadLine());
            int minPristigane = int.Parse(Console.ReadLine());

            int examInMinutes = (hourExam * 60) + minExam; //9.00
            int pristiganeInMinutes = (hourPristigane * 60) + minPristigane; // 8.00

            int result = pristiganeInMinutes - examInMinutes; //-1.00

            int cqlaChas = result / 60;
            int ostMin = result % 60;


            if (examInMinutes < pristiganeInMinutes)
            {
                Console.WriteLine("Late");

                if (result % 60 == 0)
                {
                    Console.WriteLine($"{cqlaChas}:00 hours after the start");
                }
                else if (cqlaChas == 0)
                {
                    Console.WriteLine($"{ostMin} minutes after the start");
                }
                else if (ostMin < 10)
                {
                    Console.WriteLine($"{cqlaChas}:0{ostMin} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{cqlaChas}:{ostMin} hours after the start");
                }
            }
            else if ((examInMinutes - pristiganeInMinutes) > 30)
            {
                Console.WriteLine("Early");

                result *= (-1);
                cqlaChas = result / 60;
                ostMin = result % 60;

                if (result % 60 == 0)
                {
                    Console.WriteLine($"{cqlaChas}:00 hours before the start");
                }
                else if (cqlaChas == 0)
                {
                    Console.WriteLine($"{ostMin} minutes before the start");
                }
                else if (ostMin < 10)
                {
                    Console.WriteLine($"{cqlaChas}:0{ostMin} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{cqlaChas}:{ostMin} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");

                result *= (-1);
                cqlaChas = result / 60;
                ostMin = result % 60;

                if (result % 60 == 0)
                {
                    Console.WriteLine($"{cqlaChas}:00 hours before the start");
                }
                else if (cqlaChas == 0)
                {
                    Console.WriteLine($"{ostMin} minutes before the start");
                }
                else if (ostMin < 10)
                {
                    Console.WriteLine($"{cqlaChas}:0{ostMin} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{cqlaChas}:{ostMin} hours before the start");
                }
            }
            
        }
    }
}
