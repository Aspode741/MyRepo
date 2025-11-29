using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число с различными цифрами");
            long num = long.Parse(Console.ReadLine());

            long t = num;
            bool f = false;

            while (t > 0 && !f)
            {
                int d1 = (int)(t % 10);
                long t2 = t / 10;

                while (t2 > 0)
                {
                    int d2 = (int)(t2 % 10);
                    if (d1 == d2)
                    {
                        f = true;
                        break;
                    }
                    t2 /= 10;
                }
                t /= 10;
            }

            if (f)
            {
                Console.WriteLine("Ошибка: цифры в числе не различны");
                return;
            }

            int m1 = -1;
            int m2 = -1;
            int i1 = -1;
            int i2 = -1;
            int i = 0;

            t = num;
            while (t > 0)
            {
                int d = (int)(t % 10);

                if (d > m1)
                {
                    m2 = m1;
                    i2 = i1;
                    m1 = d;
                    i1 = i;
                }
                else if (d > m2)
                {
                    m2 = d;
                    i2 = i;
                }

                i++;
                t /= 10;
            }

            if (i2 == -1)
                i2 = -1;

            Console.WriteLine($"Наибольшая цифра {m1} - позиция {i1 + 1} (справа)");
            Console.WriteLine($"Вторая по величине цифра {m2} - позиция {(i2 == -1 ? -1 : i2 + 1)} (справа)");
        }
    }
}
