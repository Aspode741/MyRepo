using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало интервала a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец интервала b");
            int b = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine("Ошибка: a должно быть меньше b");
                return;
            }

            int minSum = int.MaxValue;
            int resultNumber = -1;

            for (int n = a; n <= b; n++)
            {
                if (n <= 1) continue;

                int sum = 0;
                bool h = false;

                for (int d = 2; d <= n / 2; d++)
                {
                    if (n % d == 0)
                    {
                        if (d % 2 != 0)
                        {
                            sum += d;
                            h = true;
                        }
                    }
                }

                if (h && sum < minSum)
                {
                    minSum = sum;
                    resultNumber = n;
                }
            }

            if (resultNumber == -1)
                Console.WriteLine("В интервале нет чисел с нечетными делителями");
            else
                Console.WriteLine($"Число {resultNumber} имеет наименьшую сумму нечетных делителей = {minSum}");
        }
    }
}
