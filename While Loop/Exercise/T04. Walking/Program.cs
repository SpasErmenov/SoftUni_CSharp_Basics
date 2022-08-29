using System;

namespace T03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dailyTarget = 10000;
            int sum = 0;

            while (true)
            {
                string cmd = Console.ReadLine();
                int steps;
                if (cmd == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    sum += steps;
                    if (sum < dailyTarget)
                    {
                        Console.WriteLine($"{dailyTarget - sum} more steps to reach goal.");
                        break;
                    }
                    else if (sum >= dailyTarget)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{sum - dailyTarget} steps over the goal!");
                        break;
                    }
                }
                steps = int.Parse(cmd);
                sum += steps;
                if (sum >= dailyTarget)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sum - dailyTarget} steps over the goal!");
                    break;
                }
                
            }
        }
    }
}
