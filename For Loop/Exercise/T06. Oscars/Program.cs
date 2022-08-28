using System;

namespace T06_Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double tochkiOtAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double result = tochkiOtAcademy;

            for (int i = 0; i < n; i++)
            {
                string ocenqvashtName = Console.ReadLine();
                double tochkiOtOcenqvasht = double.Parse(Console.ReadLine());

                //imeto na string .Lenght

                result = result + ((ocenqvashtName.Length * tochkiOtOcenqvasht) / 2);

                if (result >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {result:F1}!");
                    break;
                }

            }
            if (result < 1250.5)
            {
                double diff = 1250.5 - result;
                Console.WriteLine($"Sorry, {actor} you need {diff:F1} more!");
            }
            
            //else
            //{
            //    double diff = 1250.5 - result;
            //    Console.WriteLine($"Sorry, {actor} you need {diff:F1} more!");
            //}

        }
    }
}
