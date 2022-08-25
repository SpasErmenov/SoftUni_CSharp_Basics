using System;

namespace T04Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vocation = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double puzzlePrice = puzzle * 2.6;
            int dollPrice = doll * 3;
            double bearPrice = bear * 4.1;
            double minionPrice = minion * 8.2;
            int truckPrice = truck * 2;

            int nToys = puzzle + doll + bear + minion + truck;
            double totalPrice = puzzlePrice + dollPrice + bearPrice + minionPrice + truckPrice;
            double priceWithDiscount = 0;
            double rent = 0.1;

            if (nToys >= 50)
            {
                priceWithDiscount = totalPrice * 0.25;
                totalPrice -= priceWithDiscount;

            }
            totalPrice = totalPrice - totalPrice * 0.1;

            double moneyLeft = totalPrice - vocation;
            double moneyNotEnough = vocation - totalPrice;

            if (totalPrice >= vocation)
            {
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyNotEnough:F2} lv needed.");
            }
        }
    }
}
