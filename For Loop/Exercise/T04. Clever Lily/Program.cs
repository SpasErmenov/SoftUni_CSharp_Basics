using System;

namespace T04_Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int chetni = 0;
            int neChetni = 0;

            int pari = 0;
            int x = 0;
            int brIgrachki = 0;
            double pariOtIgrachki = 0;
            double spesteni = 0;
            double diff = 0;

            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    chetni = chetni + 1;
                    pari = pari + 10;
                    x = x + pari;
                }
                else
                {
                    neChetni = neChetni + 1;
                }
                
            }
            pariOtIgrachki = neChetni * toyPrice;


            spesteni = (x + pariOtIgrachki) - chetni;

            //Console.WriteLine(x);
            //Console.WriteLine(pariOtIgrachki);
            //Console.WriteLine(neChetni);
            //Console.WriteLine(spesteni);

            

            if (spesteni >= machinePrice)
            {
                diff = spesteni - machinePrice;
                Console.WriteLine($"Yes! {diff:F2}");
            }
            else
            {
                diff = machinePrice - spesteni;
                Console.WriteLine($"No! {diff:F2}");
            }

        }
    }
}
