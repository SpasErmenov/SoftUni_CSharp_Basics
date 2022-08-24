using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int nChickenMenu = int.Parse(Console.ReadLine());
            int nFishMenu = int.Parse(Console.ReadLine());
            int nVeganMenu = int.Parse(Console.ReadLine());
            double delivery = 2.5;

            double nChickenMenuPrice = nChickenMenu * 10.35;
            double nFishMenuPrice = nFishMenu * 12.40;
            double nVeganMenuPrice = nVeganMenu * 8.15;

            double bill = nChickenMenuPrice + nFishMenuPrice + nVeganMenuPrice;
            double billPlusDesert = bill + (bill * 0.2);
            double total = billPlusDesert + delivery;

            Console.WriteLine(total);
        }
    }
}
