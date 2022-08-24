using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearFee = int.Parse(Console.ReadLine());

            double basketballShoes = yearFee - (yearFee * 0.4);
            double basketballCloths = basketballShoes - (basketballShoes * 0.2);
            double basketballBall = basketballCloths / 4;
            double basketballAcs = basketballBall / 5;

            double total = yearFee + basketballShoes + basketballCloths + basketballBall + basketballAcs;
            Console.WriteLine(total);
        }
    }
}
