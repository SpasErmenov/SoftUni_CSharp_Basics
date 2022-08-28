using System;

namespace T02_Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int bigN = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum = sum + a;
                if (a > bigN)
                {
                    bigN = a;
                }
            }
            sum = sum - bigN;
            //Console.WriteLine(bigN);
            //Console.WriteLine(sum);

            if (bigN == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + bigN);
            }
            else
            {
                int diff = Math.Abs(bigN - sum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + diff);
            }
        }
    }
}
