using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double priceClothsPerStatis = double.Parse(Console.ReadLine());

            double priceForCloths = statisti * priceClothsPerStatis;
            double decoration = budged - (budged * 0.9);

            if (statisti > 150)
            {
                priceForCloths -= priceForCloths * 0.1;


                if ((decoration + priceForCloths) > budged)
                {
                    Console.WriteLine("Not enough money!");
                    double levaMore = (budged - (decoration + priceForCloths))*(-1);
                    Console.WriteLine($"Wingard needs {levaMore:F2} leva more.");
                }
                else
                {
                    double moneyForFilming = priceForCloths + decoration;
                    double moneyLeft = budged - moneyForFilming;

                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
                }
            }
            else
            {
                if ((decoration + priceForCloths) > budged)
                {
                    Console.WriteLine("Not enough money!");
                    double levaMore = (budged - (decoration + priceForCloths)) * (-1);
                    Console.WriteLine($"Wingard needs {levaMore:F2} leva more.");
                }
                else
                {
                    double moneyForFilming = priceForCloths + decoration;
                    double moneyLeft = budged - moneyForFilming;

                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
                }
            }

        }
    }
}
