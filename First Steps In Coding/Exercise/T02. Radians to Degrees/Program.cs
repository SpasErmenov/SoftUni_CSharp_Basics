using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double degree = r * 180 / Math.PI;

            Console.WriteLine(degree);
        }
    }
}
