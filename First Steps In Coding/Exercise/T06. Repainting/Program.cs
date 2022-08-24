using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nailon = double.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hRabota = int.Parse(Console.ReadLine());
            double torbichka = 0.4;


            double nailonPrice = (nailon + 2) * 1.5;
            double boqPrice = (boq + boq * 0.1) * 14.5;
            double razreditelPrice = razreditel * 5;

            double moneySpentForMats = nailonPrice + boqPrice + razreditelPrice + torbichka;
            double moneyPerHourForWork = moneySpentForMats * 0.3;

            double total = moneySpentForMats + (moneyPerHourForWork * hRabota);

            Console.WriteLine(total);

        }
    }
}
