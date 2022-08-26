using System;

namespace T02_Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradus = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string shoes;
            string outfit;


            if (gradus >= 10 && gradus <=18)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Afternoon":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
                        break;
                    default:
                        break;
                }
            }
            else if (gradus > 18 && gradus<= 24)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
                        break;
                    default:
                        break;
                }
            }
            else if (gradus >= 25)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
