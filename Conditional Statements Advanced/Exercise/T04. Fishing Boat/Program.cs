using System;

namespace T04_Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budged = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            int boatPrice = 0;
            double moneyNeeded = 0;

            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case ("Winter"):
                    boatPrice = 2600;
                    break;
                default:
                    break;
            }
            

            if (n <= 6)
            {
                totalPrice = boatPrice - (boatPrice * 0.1);
            }
            else if (n > 6 && n <= 11)
            {
                totalPrice = boatPrice - (boatPrice * 0.15);
            }
            else if (n > 11)
            {
                totalPrice = boatPrice - (boatPrice * 0.25);
            }

            if (season != "Autumn")
            {
                if (n % 2 == 0)
                {
                    totalPrice = totalPrice - (totalPrice * 0.05);
                }
            }

            if (totalPrice > budged)
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budged:F2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budged - totalPrice:F2} leva left.");
            }
        }
    }
}
