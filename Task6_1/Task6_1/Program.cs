using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");

            var x = Console.ReadLine();
            var y = F(x);

            Console.WriteLine(y);

        }

        static string F(string x)
        {
            var b = x.ToUpper();

            var y = b.Replace("А", "A").Replace("Б", "б").Replace("В", "В").Replace("Г", "r").Replace("Д", "D").Replace("Е", "Е").Replace("Ё", "Е").Replace("Ж", "}|{").Replace("З", "З").Replace("И", "u").Replace("Й", "u*").Replace("К", "K").Replace("Л", "JI").Replace("М", "Р").Replace("Н", "Н").Replace("О", "О").Replace("П", "n").Replace("Р", "Р").Replace("С", "С").Replace("Т", "Т").Replace("У", "Y").Replace("Ф", "cp").Replace("Х", "X").Replace("Ц", "L|").Replace("Ч", "4").Replace("Ш", "LLI").Replace("Щ", "LLL").Replace("Ъ", "`b").Replace("Ы", "bI").Replace("Ь", "b").Replace("Э", "-)").Replace("Ю", "IO").Replace("Я", "9I");

            return y;
        }
    }
}
