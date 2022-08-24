using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int stackPens = int.Parse(Console.ReadLine());
            int stackMarkers = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());

            double pensPrice = stackPens * 5.8;
            double markerPrice = stackMarkers * 7.2;
            double boardCleanerPrice = boardCleaner * 1.2;
            double discountPercentCalculated = (discountPercent / 100);

            double totalPriceWithoutDiscount = pensPrice + markerPrice + boardCleanerPrice;
            double totalPriceWithDiscount = totalPriceWithoutDiscount - (totalPriceWithoutDiscount * discountPercentCalculated);

            Console.WriteLine(totalPriceWithDiscount);


        }
    }
}
