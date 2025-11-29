using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива");

            var n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Слишком маленький массив.");
                return;
            }

            var a = new double[n];
            var gen = new Random();

            for (int i = 0; i < a.Length; i++)
                a[i] = gen.NextDouble();

            PrintDoubleArray(a);
        }

        static void PrintDoubleArray(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]:F4}");
                if (i < a.Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}