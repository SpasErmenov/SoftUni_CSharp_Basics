using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalAverage = 0;
            double totalNumberOfPresentations = 0;
            while (true)
            {
                string nameOFPresentation = Console.ReadLine();

                if (nameOFPresentation.Equals ("Finish"))
                {
                    totalAverage /= (totalNumberOfPresentations * n);
                    Console.WriteLine($"Student's final assessment is {totalAverage:F2}.");
                    break;
                }

                double average = 0;
                for (int i = 0; i < n; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    average += mark;
                    totalAverage += mark;
                }
                average /= n;

                Console.WriteLine($"{nameOFPresentation} - {average:F2}.");

                totalNumberOfPresentations++;
             }
        }
    }
}
