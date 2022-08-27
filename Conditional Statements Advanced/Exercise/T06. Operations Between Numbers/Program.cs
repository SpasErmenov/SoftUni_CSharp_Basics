using System;

namespace T06_Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            string znak = Console.ReadLine();
            double result = 0;

            switch (znak)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                case "%":
                    result = n1 % n2;
                    break;
                default:
                    break;
            }
            Math.Round(result, 2);
                if (znak == "+" || znak == "-" || znak == "*")
                {
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} {znak} {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {znak} {n2} = {result} - odd");
                    }
                }
                else if (znak == "/")
                {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
                }
                else if (znak == "%")
                {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }

            
        }
    }
}
