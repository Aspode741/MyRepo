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
            Console.WriteLine("Введите пятизначное число");

            var n = int.Parse(Console.ReadLine());

            var pat = n % 10;
            var tri = (n % 1000) / 100;
            var odin = (n % 100000) / 10000;

            string result = string.Format("{0}{1}{2}", odin, pat, tri);
            Console.WriteLine("Ваше число:" + result);
        }
    }
}
