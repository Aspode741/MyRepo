using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус нижнего основания: ");
            var R = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус верхнего основания: ");
            var r = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту усеченного конуса: ");
            var h = int.Parse(Console.ReadLine());

            
            var volume = (1.0 / 3.0) * Math.PI * h * (R * R + R * r + r * r);

            //образующfz
            var l = Math.Sqrt(h * h + (R - r) * (R - r));

            // S
            var surfaceArea = Math.PI * (R * R + r * r + l * (R + r));


            Console.WriteLine("Объем усеченного конуса: " + Math.Round(volume));
            Console.WriteLine("Площадь поверхности: " + Math.Round(surfaceArea));
        }
    }
}
