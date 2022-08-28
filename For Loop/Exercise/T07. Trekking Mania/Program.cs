using System;

namespace T07_Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double grpOne = 0;
            double grpTwo = 0;
            double grpThree = 0;
            double grpFour = 0;
            double grpFive = 0;

            int sum = 0;


            for (int i = 0; i < groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                sum = sum + peopleInGroup;

                if (peopleInGroup <= 5)
                {
                    grpOne = grpOne + peopleInGroup;
                }
                else if (peopleInGroup > 5 && peopleInGroup <= 12)
                {
                    grpTwo = grpTwo + peopleInGroup;
                }
                else if (peopleInGroup > 12 && peopleInGroup <= 25)
                {
                    grpThree = grpThree + peopleInGroup;
                }
                else if (peopleInGroup > 25 && peopleInGroup <= 40)
                {
                    grpFour = grpFour + peopleInGroup;
                }
                else if(peopleInGroup >= 41)
                {
                    grpFive = grpFive + peopleInGroup;
                }
            }
            //Console.WriteLine(sum);
            //Console.WriteLine(grpOne);
            Console.WriteLine($"{((grpOne / sum) * 100):F2}%");
            Console.WriteLine($"{((grpTwo / sum) * 100):F2}%");
            Console.WriteLine($"{((grpThree / sum) * 100):F2}%");
            Console.WriteLine($"{((grpFour / sum) * 100):F2}%");
            Console.WriteLine($"{((grpFive / sum) * 100):F2}%");

        }
    }
}
