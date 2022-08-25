using System;

namespace T08Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            double episodeTime = int.Parse(Console.ReadLine());
            double breakTime = int.Parse(Console.ReadLine());

            double vremeZaHranene = breakTime / 8;
            double vremeZaOtdih = breakTime / 4;

            //Console.WriteLine(vremeZaHranene);
            //Console.WriteLine(vremeZaOtdih);

            double izminaloVreme = vremeZaHranene + vremeZaOtdih;
            double ostavashtoVreme = breakTime - izminaloVreme;

            //Console.WriteLine(izminaloVreme);

            if (ostavashtoVreme >= episodeTime)
            {
                ostavashtoVreme = breakTime - izminaloVreme - episodeTime;
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(ostavashtoVreme)} minutes free time.");
            }
            else
            {
                double needTime = (breakTime - izminaloVreme - episodeTime) * (-1);
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(needTime)} more minutes.");
            }

        }
    }
}
