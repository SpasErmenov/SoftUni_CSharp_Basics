using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int x = a; x <= b; x++)
            {
                int sum1 = 0;
                int sum2 = 0;
                int num = x;
                int c = 0;
                while (num > 0)
                {
                    if (c % 2 == 0)
                    {
                        sum1 += num % 10;
                    }


                    if (c % 2 == 1)
                    {
                        sum2 += num % 10;
                    }

                    num = num / 10;

                    c++;
                }

                if (sum1 == sum2)
                {
                    Console.Write($"{x} ");
                }
            }
        }
    }
}
