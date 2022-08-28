using System;

namespace T08_Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int turniri = int.Parse(Console.ReadLine());
            int nachalniTochki = int.Parse(Console.ReadLine());

            string wlr = "as";
            double points = nachalniTochki;
            double wins = 0;



            for (int i = 0; i < turniri; i++)
            {
                wlr = Console.ReadLine();

                switch (wlr)
                {
                    case "W":
                        points = points + 2000;
                        wins = wins + 1;
                        break;
                    case "F":
                        points = points + 1200;
                        break;
                    case "SF":
                        points = points + 720;
                        break;

                    default:
                        break;
                }

            }
            double avarage = (points - nachalniTochki) / turniri;

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(avarage)}");
            Console.WriteLine($"{((wins/turniri) * 100):F2}%");
        }
    }
}
