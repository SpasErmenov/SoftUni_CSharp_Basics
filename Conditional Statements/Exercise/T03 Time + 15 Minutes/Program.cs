using System;

namespace T03Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());


            if (hour >= 0 && hour <= 23 && min >= 0 && min <= 59)
            {

                int minPlusFiveteen = min + 15;
                int ostMin = minPlusFiveteen % 60;

                if (minPlusFiveteen >= 60)
                {
                    hour += 1;
                }
                if (hour >= 24)
                {
                    hour -= 24;
                }

                if (ostMin < 10)
                {
                    Console.WriteLine($"{hour}:0{ostMin}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{ostMin}");
                }
            }
        }
    }
}
