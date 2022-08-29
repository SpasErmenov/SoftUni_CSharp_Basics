using System;

namespace T02_Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int nezadovolen = int.Parse(Console.ReadLine());

            string imeNaZadacha = Console.ReadLine();
            double ocenka = double.Parse(Console.ReadLine());
            string lastPproblem = "";

            int sum = 0;
            double average = ocenka;
            int problems = 0;

            bool enough = false;

            while (enough != true)
            {
                lastPproblem = imeNaZadacha;
                imeNaZadacha = Console.ReadLine();
                problems += 1;

                if (imeNaZadacha == "Enough")
                {
                    break;
                }

                ocenka = double.Parse(Console.ReadLine());
                average += ocenka;

                if (ocenka <= 4)
                {
                    sum += 1;
                }
                if (sum >= nezadovolen)
                {
                    break;
                }
            }
            if (imeNaZadacha == "Enough")
            {
                Console.WriteLine($"Avarage score: {average/problems}");
                Console.WriteLine($"Number of problems: {problems}");
                Console.WriteLine($"Last problem: {lastPproblem}");
            }
        }
    }
}
