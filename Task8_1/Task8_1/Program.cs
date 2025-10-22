using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    internal class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Введитее число m");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число n");
            var n = int.Parse(Console.ReadLine());

            if (Qw(m, n))
                Console.WriteLine("Только одно число из чисел m и n делится на 2, но не делится ни на 3, ни на 5");
            else Console.WriteLine("Либо оба числа из чисел m и n не делятся на 2, но делится на 3 и на 5,"
                + "либо оба из чисел m и n делятся на 2, но не делятся ни на 3, ни на 5");
        }
        static bool Qw(int m, int n) =>
            ((m % 2 == 0) && (m % 3 != 0) && (m % 5 != 0) && ((n % 2 != 0) || (n % 3 == 0) || (n % 5 == 0))) ||
            ((n % 2 == 0) && (n % 3 != 0) && (n % 5 != 0) && ((m % 2 != 0) || (m % 3 == 0) || (m % 5 == 0)));
    }
}
