using System;
using System.Diagnostics;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long k = 0;
            long limit = 100000000;

            Console.WriteLine("Подсчёт реверсивных чисел от 10 до 100 000 000 (не включительно)");

            for (long n = 10; n < limit; n++)
            {
                if (n % 10 == 0)
                {
                    continue;
                }
                ;

                if (ProverkaChotneChot(n))
                {
                    k++;
                }
            }


            Console.WriteLine($"Всего реверсивных чисел меньше 100000000 и больше 9: {k}");
        }

        static bool ProverkaChotneChot(long n)
        {
            long summa = n + PovorotN(n);

            if (summa % 2 == 0) return false;

            long vremennoe = summa;
            while (vremennoe > 0)
            {
                if ((vremennoe % 10) % 2 == 0) return false;
                vremennoe /= 10;
            }

            return true;
        }

        static long PovorotN(long n)
        {
            long obratnoe = 0;
            long vremennoe = n;

            while (vremennoe > 0)
            {
                obratnoe = obratnoe * 10 + (vremennoe % 10);
                vremennoe /= 10;
            }

            return obratnoe;
        }
    }
}