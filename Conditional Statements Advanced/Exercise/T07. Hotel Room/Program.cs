using System;

namespace T07_Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            double totalPriceApartment = 0;
            double totalPriceStudio = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
                default:
                    break;
            }
            if ((nights > 7 && nights <=13) && (month == "May" || month == "October"))
            {
                studioPrice = studioPrice - (studioPrice * 0.05);
            }
            else if (nights > 14 && (month == "May" || month == "October"))
            {
                studioPrice = studioPrice - (studioPrice * 0.3);
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                studioPrice = studioPrice - (studioPrice * 0.2);
            }
            if (nights > 14)
            {
                apartmentPrice = apartmentPrice - (apartmentPrice * 0.1);
            }
            totalPriceApartment = apartmentPrice * nights;
            totalPriceStudio = studioPrice * nights;

            //Console.WriteLine(studioPrice);
            //Console.WriteLine(apartmentPrice);

            Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
        }
    }
}
