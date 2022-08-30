using System;

namespace sum_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (String.Equals(line, "stop" ) == true)
                {
                    break;
                }

                int num = int.Parse(line);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                bool isPrime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true)
                {
                    sumPrime += num;
                }
                if (isPrime == false)
                {
                    sumNonPrime += num;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
