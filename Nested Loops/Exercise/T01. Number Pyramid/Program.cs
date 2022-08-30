using System;

namespace Nested_Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            bool isBigger = false;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{num} ");
                    if (num >= n)
                    {
                        isBigger = true;
                        break;
                    }
                    num++;
                }
                Console.WriteLine();
                if (isBigger)
                {
                    break;
                }
            }
        }
    }
}
