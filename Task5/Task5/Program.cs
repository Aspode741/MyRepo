using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate(2, 3) + Calculate(5, 7) + Calculate(11, 13);
            Console.WriteLine(Math.Round(x, 3));
        }

        static double Calculate(double a, double b) =>
            Math.Sqrt((1 + a * a) / b * b);

    }
}
