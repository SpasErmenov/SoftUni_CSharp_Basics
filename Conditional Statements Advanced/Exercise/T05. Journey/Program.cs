using System;

namespace T05_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string place = "";
            double totalPrice = 0;

            if (budged <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    totalPrice = budged * 0.3;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    totalPrice = budged * 0.7;
                    place = "Hotel";
                }
                
            }
            else if (budged <= 1000 && budged > 100)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    totalPrice = budged * 0.4;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    totalPrice = budged * 0.8;
                    place = "Hotel";
                }
            }
            else if (budged > 1000)
            {
                destination = "Europe";
                place = "Hotel";
                totalPrice = budged * 0.9;
                
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {totalPrice:F2}");
            
        }
    }
}
