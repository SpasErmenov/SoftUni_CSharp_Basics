using System;

namespace T09_Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rate = Console.ReadLine();

            const double roomForOnePerson = 18;
            const double apartment = 25;
            const double presidentRoom = 35;

            int nights = days - 1;

            double total = 0;

            switch (room)
            {
                case "apartment":

                    total = (nights * apartment);

                    if (nights < 10)
                    {
                        total -= total * 0.3;
                    }
                    else if (nights > 15)
                    {
                        total -= total * 0.5;
                    }
                    else
                    {
                        total -= total * 0.35;
                    }
                    break;

                case "president apartment":

                    total = (nights * presidentRoom);

                    if (nights < 10)
                    {
                        total -= total * 0.1;
                    }
                    else if (nights > 15)
                    {
                        total -= total * 0.2;
                    }
                    else
                    {
                        total -= total * 0.15;
                    }
                    break;

                default:

                    total = (nights * roomForOnePerson);

                    break;
            }

            switch (rate)
            {
                case "positive":
                    total += total * 0.25;
                    break;

                case "negative":
                    total -= total * 0.1;
                    break;

                default:
                    break;
            }

            Console.WriteLine($"{total:F2}");
        }
    }
}
