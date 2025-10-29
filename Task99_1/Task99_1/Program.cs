using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task99_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента");

            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x:F2})={F(x):F2}");
        }

        static double F(double x)
        {
            if (x < -5) return 25 - x * x;
            else if (x <= 5) return x * x - 25;
            else return Math.Sqrt(x - 5);
        }
    }
}
