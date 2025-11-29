using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите натуральное число k");
            int k = int.Parse(Console.ReadLine());

            double s = 1;
            s += n;

            for (int i = 2; i <= k; i++)
            {
                s += Math.Pow(n, 1.0 / i);
            }

            Console.WriteLine($"Сумма = {s:F5}");
        }
    }
}
