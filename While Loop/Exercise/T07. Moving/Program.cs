using System;

namespace T07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int cubicMeters = x * y * z;

            string cmd;

            while ((cmd = Console.ReadLine()) != "Done")
            {
                int size = int.Parse(cmd);

                cubicMeters -= size;

                if (cubicMeters < 0)
                {
                    Console.WriteLine($"No more free space! You need {cubicMeters * (-1)} Cubic meters more.");
                    break;
                }
            }

            if (cubicMeters > 0)
            {
                Console.WriteLine($"{cubicMeters} Cubic meters left.");
            }
        }
    }
}
