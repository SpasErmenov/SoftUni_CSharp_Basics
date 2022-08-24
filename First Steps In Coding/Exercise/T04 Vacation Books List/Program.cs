using System;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesPerBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int readedPagesPerHour = (pagesPerBook / pagesPerHour);
            int pagesPerDay = readedPagesPerHour / days;

            Console.WriteLine(pagesPerDay);


        }
    }
}
