using System;

namespace T06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            string cmd;
            int cakePieces = lenght * width;

            while ((cmd = Console.ReadLine()) != "STOP")
            {
                int cakePiece = int.Parse(cmd);
                cakePieces -= cakePiece;

                if (cakePieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {cakePieces * (-1)} pieces more.");
                    break;
                }
            }

            if (cakePieces >= 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
        }
    }
}
