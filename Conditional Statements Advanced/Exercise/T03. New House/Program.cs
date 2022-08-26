using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int Roses = 5;
            double Dahlias = 3.80;
            double Tulips = 2.80;
            int Narcissus = 3;
            double Gladiolus = 2.50;

            double totalPrice = 0;

            if (flowersType == "Roses")
            {
                totalPrice = Roses * flowersCount;
                if (flowersCount > 80)
                {
                    totalPrice -= totalPrice * 0.10;
                }
            }
            else if (flowersType == "Dahlias")
            {
                totalPrice = Dahlias * flowersCount;
                if (flowersCount > 90)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowersType == "Tulips")
            {
                totalPrice = Tulips * flowersCount;
                if (flowersCount > 80)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowersType == "Narcissus")
            {
                totalPrice = Narcissus * flowersCount;
                if (flowersCount < 120)
                {
                    totalPrice += totalPrice * 0.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                totalPrice = Gladiolus * flowersCount;
                if (flowersCount < 80)
                {
                    totalPrice += totalPrice * 0.20;
                }
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - totalPrice:F2} leva left.");
            }
            else if (totalPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need { totalPrice - budget:F2} leva more.");
            }
        }
    }
}
