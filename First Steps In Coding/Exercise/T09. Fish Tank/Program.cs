using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double h = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double percentCalculated = percent / 100;
            double FishTankvInDm3 = (a * b * h) / 1000;
            double FishTankWater = FishTankvInDm3 * (1 - percentCalculated);

            Console.WriteLine(FishTankWater);

        }
    }
}
