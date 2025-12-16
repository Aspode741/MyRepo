using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            while (true)
            {
                Console.WriteLine("Введите через пробел два натуральных числа m и n от 5 до 20");
                Console.WriteLine("(Enter - отказ от ввода)");
                var vvod = Console.ReadLine();

                if (vvod == string.Empty)
                    return;

                var chasti = vvod.Split();

                if (chasti.Length == 2 && int.TryParse(chasti[0], out m) &&
                    int.TryParse(chasti[1], out n) && 5 <= m && m <= 20 &&
                    5 <= n && n <= 20)
                    break;
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }
            }

            var matrix = new int[m, n];

            var random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(0, 100);

            Console.WriteLine();

            VivestiMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("Введите цифру от 0 до 9:");
            var tsifra = int.Parse(Console.ReadLine());

            var resultatPoiska = NaytiChisloSOkonchaniem(matrix, tsifra);

            if (resultatPoiska.stroka >= 0)
                Console.WriteLine($"Число {matrix[resultatPoiska.stroka, resultatPoiska.stolbets]} " +
                                  $"найдено в строке {resultatPoiska.stroka+1}, столбце {resultatPoiska.stolbets+1}");
            else
                Console.WriteLine($"Числа, оканчивающегося на {tsifra}, нет в массиве");

            Console.WriteLine();

            var minimalnyeElementy = NaytiMinimalnyeVStrokakh(matrix);

            for (int i = 0; i < minimalnyeElementy.Length; i++)
                Console.WriteLine($"Строка {i+1}: минимальный элемент = {minimalnyeElementy[i]}");
        }

        static void VivestiMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],3} ");

                Console.WriteLine();
            }
        }

        static (int stroka, int stolbets) NaytiChisloSOkonchaniem(int[,] matrix, int tsifra)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 10 == tsifra)
                        return (i, j);
                }
            }

            return (-1, -1);
        }

        static int[] NaytiMinimalnyeVStrokakh(int[,] matrix)
        {
            var resultat = new int[matrix.GetLength(0)];

            for (int stroka = 0; stroka < matrix.GetLength(0); stroka++)
            {
                int min = int.MaxValue;

                for (int stolbets = 0; stolbets < matrix.GetLength(1); stolbets++)
                {
                    if (matrix[stroka, stolbets] < min)
                        min = matrix[stroka, stolbets];
                }

                resultat[stroka] = min;
            }

            return resultat;
        }
    }
}