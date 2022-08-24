using System;

namespace sf
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            const double bgn = 1.79549;

            double formula = usd * bgn;

            Console.WriteLine(formula);
        }
    }
}
