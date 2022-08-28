using System;

namespace T03_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a >= 1 && a < 200)
                {
                    p1 = p1 + 1;
                }
                else if (a >= 200 && a < 400)
                {
                    p2 = p2 + 1;
                }
                else if (a >= 400 && a < 600)
                {
                    p3 = p3 + 1;
                }
                else if (a >= 600 && a < 800)
                {
                    p4 = p4 + 1;
                }
                else if(a >= 800)
                {
                    p5 = p5 + 1;
                }
            }
            p1 = p1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;


            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
