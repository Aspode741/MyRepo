using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение");
            var a = Console.ReadLine();

            if (string.IsNullOrEmpty(a))
            {
                Console.WriteLine("Введена пустая строка.");
            }
            else if (int.TryParse(a, out int intValue))
            {
                Console.WriteLine($"Данное число {intValue} относится к целочисленному типу данных int.(32)");
            }
            else if (long.TryParse(a, out long longValue))
            {
                Console.WriteLine($"Данное число {longValue} относится к целочисленному типу данных long.(64)");
            }
            else if (float.TryParse(a, out float floatValue))
            {
                Console.WriteLine($"Данное число {floatValue} относится к вещественному типу данных float.(32)");
            }
            else if (double.TryParse(a, out double doubleValue))
            {
                Console.WriteLine($"Данное число {doubleValue} относится к вещественному типу данных double.(64)");
            }
            else if (decimal.TryParse(a, out decimal decimalValue))
            {
                Console.WriteLine($"Данное число {decimalValue} относится к десятичному типу данных decimal.(128)");
            }
            else if (bool.TryParse(a, out bool boolValue))
            {
                Console.WriteLine($"Значение {boolValue} относится к логическому типу данных bool.");
            }
            else if (a.Length == 1 && char.TryParse(a, out char charValue))
            {
                Console.WriteLine($"Значение '{charValue}' относится к символьному типу данных char.(16)");
            }
            else
            {
                Console.WriteLine($"Введенное значение '{a}' относится к строковому типу данных string, или другим типам-ссылкам или составному");
            }

        }
    }
}
