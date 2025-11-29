using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            long n = long.Parse(Console.ReadLine());

            long r = -1;

            for (long d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                {
                    long sd = (long)Math.Sqrt(d);
                    if (sd * sd == d)
                    {
                        r = d;
                        break;
                    }

                    long q = n / d;
                    long sq = (long)Math.Sqrt(q);
                    if (sq * sq == q)
                    {
                        if (r == -1 || q < r)
                            r = q;
                    }
                }
            }

            long sn = (long)Math.Sqrt(n);
            if (sn * sn == n && (r == -1 || n < r))
                r = n;

            if (r == -1)
                Console.WriteLine("У числа нет делителей, являющихся квадратами");
            else
                Console.WriteLine($"Наименьший делитель-квадрат = {r}");
        }
    }
}
