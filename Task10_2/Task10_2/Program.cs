using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            int n = int.Parse(Console.ReadLine());

            double s = 0;
            double p = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-е число");
                double x = double.Parse(Console.ReadLine());

                p *= x;
                s += p;
            }

            Console.WriteLine($"Результат = {s:F5}");
        }
    }
}
