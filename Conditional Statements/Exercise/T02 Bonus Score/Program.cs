using System;

namespace T02Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            double bonusPoints2 = 0;

            if (score <= 100)
            {
                bonusPoints = 5;
            }
            else if (score > 100 && score < 1000)
            {
                bonusPoints = score * 0.2;
            }
            else
            {
                bonusPoints = score * 0.1;
            }

            if (score % 2 == 0)
            {
                bonusPoints2 = 1;
            }
            else if (score % 5 == 0)
            {
                bonusPoints2 = 2;
            }

            double totalScore = score + bonusPoints + bonusPoints2;
            double totalBonus = bonusPoints + bonusPoints2;

            Console.WriteLine(totalBonus);
            Console.WriteLine(totalScore);

        }
    }
}
