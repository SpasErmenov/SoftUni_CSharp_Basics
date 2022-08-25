using System;

namespace T06World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordToBeat = double.Parse(Console.ReadLine());
            double distanceToSwim = double.Parse(Console.ReadLine());
            double stoqnVremeZaMetur = double.Parse(Console.ReadLine());

            double putiZabavenoVreme = Math.Floor(distanceToSwim / 15);
            double zabavenoVreme = (putiZabavenoVreme * 12.5);

            double vremeNaIvan = (distanceToSwim * stoqnVremeZaMetur) + zabavenoVreme;


            if (vremeNaIvan < recordToBeat)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {vremeNaIvan:F2} seconds.");
            }
            else
            {
                double nedostigashtoVreme = vremeNaIvan - recordToBeat;
                Console.WriteLine($"No, he failed! He was {nedostigashtoVreme:F2} seconds slower.");
            }


        }
    }
}
