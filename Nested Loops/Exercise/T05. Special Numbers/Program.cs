using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

                for (int i = 1111; i <= 9999; i++)
                {
                int a = i / 1 % 10;
                int b = i / 10 % 10;
                int c = i / 100 % 10;
                int d = i / 1000 % 10;

                if (a == 0 || b == 0 || c == 0 || d == 0)
                {
                    continue;
                }


                if ((N % a == 0) && (N % b == 0) && (N % c == 0) && (N % d == 0))
                {
                Console.Write(i + " ");
            }
        }
                
        }
    }
}

