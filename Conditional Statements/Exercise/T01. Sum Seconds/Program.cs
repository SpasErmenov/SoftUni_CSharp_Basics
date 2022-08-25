using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int sec = firstTime + secondTime + thirdTime;

            //int sec = int.Parse(Console.ReadLine());

            int cqlaMin = sec / 60;
            int ostSec = sec % 60;

            if (sec % 60 == 0)
            {
                Console.WriteLine($"{cqlaMin}:00");
            }
            else if (ostSec < 10)
            {
                Console.WriteLine($"{cqlaMin}:0{ostSec}");
            }
            else
            {
                Console.WriteLine($"{cqlaMin}:{ostSec}");
            }

        }
    }
}
