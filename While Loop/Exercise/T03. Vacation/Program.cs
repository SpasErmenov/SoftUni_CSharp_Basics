using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripValue = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spendingDays = 0;

            while (true)
            {
                string comand = Console.ReadLine();
                double value = double.Parse(Console.ReadLine());

                if (comand.Equals ("save"))
                {
                    availableMoney += value;
                    spendingDays = 0;
                }
                if (comand.Equals("spend"))
                {
                    if (availableMoney >= value)
                    {
                        availableMoney -= value;
                    }
                    else
                    {
                        availableMoney = 0;
                    }
                    spendingDays++;
                }

                days++;

                if (availableMoney >= tripValue)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
                if (spendingDays >=5 )
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine(days);
                    break;
                }
            }
        }
    }
}
