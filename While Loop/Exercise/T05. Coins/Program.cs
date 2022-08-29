using System;

namespace T05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resto = decimal.Parse(Console.ReadLine());
            int coinCounter = 0;

            while (resto != 0)
            {
                while (true)
                {
                    if ((resto - 2) >= 0)
                    {
                        resto -= 2;
                        coinCounter++;
                    }
                    if ((resto - 2) < 0)
                    {
                        break;
                    }
                }
                while (true)
                {
                    if ((resto - 1) >= 0)
                    {
                        resto -= 1;
                        coinCounter++;
                    }
                    if ((resto - 1) < 0)
                    {
                        break;
                    }
                }
                while (true)
                {
                    if ((resto - 0.5m) >= 0)
                    {
                        resto -= 0.5m;
                        coinCounter++;
                    }
                    if ((resto - 0.5m) < 0)
                    {
                        break;
                    }
                }
                while (true)
                {
                    if ((resto - 0.2m) >= 0)
                    {
                        resto -= 0.2m;
                        coinCounter++;
                    }
                    if ((resto - 0.2m) < 0)
                    {
                        break;
                    }
                }
                while (true)
                {
                    if ((resto - 0.1m) >= 0)
                    {
                        resto -= 0.1m;
                        coinCounter++;
                    }
                    if ((resto - 0.1m) < 0)
                    {
                        break;
                    }
                }
                while (true)
                {
                    if ((resto - 0.05m) >= 0)
                    {
                        resto -= 0.05m;
                        coinCounter++;
                    }
                    if ((resto - 0.05m) < 0)
                    {
                        break;
                    }

                }
                while (true)
                {
                    if ((resto - 0.02m) >= 0)
                    {
                        resto -= 0.02m;
                        coinCounter++;
                    }
                    if ((resto - 0.02m) < 0)
                    {
                        break;
                    }

                }
                while (true)
                {
                    if ((resto - 0.01m) >= 0)
                    {
                        resto -= 0.01m;
                        coinCounter++;
                    }
                    if ((resto - 0.01m) < 0)
                    {
                        break;
                    }

                }
            }

            Console.WriteLine(coinCounter);
        }
    }
}
