using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите действительное число");

                var x = double.Parse(Console.ReadLine());
                var y = F(x);

                Console.WriteLine("y = " + y);

            }

        static double F(double x) => Math.Pow(Math.Abs(Math.Cos(x) + Math.Pow(Math.Cos(2 * x), 2) + Math.Pow(Math.Cos(4 * x), 3)), 1.0 / 3.0);

    }
    }
