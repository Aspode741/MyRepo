using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, через Enter после каждлого числа, последовательность ненулевых целых чисел, оканчивающуюся нулем");

            int s = 0;
            int z = 1;
            int c = 0;

            while (true)
            {
                int x = int.Parse(Console.ReadLine());

                if (x == 0)
                    break;

                s += z * x;
                z = -z;
                c++;
            }

            if (c == 0)
                Console.WriteLine("Последовательность пуста");
            else
                Console.WriteLine($"Алгебраическая сумма = {s}");
        }
    }
}
