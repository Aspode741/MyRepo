using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Александр Блок");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ночь, улица, фонарь, аптека...");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ночь, улица, фонарь, аптека,");
            Console.WriteLine("Бессмысленный и тусклый свет.");
            Console.WriteLine("Живи еще хоть четверть века —");
            Console.WriteLine("Всё будет так. Исхода нет.");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Умрёшь — начнёшь опять сначала");
            Console.WriteLine("И повторится всё, как встарь:");
            Console.WriteLine("Ночь, ледяная рябь канала,");
            Console.WriteLine("Аптека, улица, фонарь.");

            Console.ResetColor();
        }
        }
    }

