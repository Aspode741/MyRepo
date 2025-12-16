using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива");

            var n = int.Parse(Console.ReadLine());

            var massiv = new double[n];
            var generator = new Random();

            for (int i = 0; i < massiv.Length; i++)
                massiv[i] = generator.NextDouble();

            Console.WriteLine("Исходный массив:");
            PrintDoubleArray(massiv);

            var kopia = new double[massiv.Length];
            Array.Copy(massiv, kopia, massiv.Length);

            DelimNaSummu(kopia);
            Console.WriteLine("\nМассив после деления на сумму элементов:");
            PrintDoubleArray(kopia);

            var summaProizvedeniy = VychislitSummuProizvedeniy(massiv);
            Console.WriteLine($"\nСумма произведений элемента на индекс: {summaProizvedeniy:F4}");

            var usrednennyeSummy = VychislitUsrednennyeSummyKvadratov(massiv);
            Console.WriteLine("\nУсреднённые частичные суммы квадратов:");
            PrintDoubleArray(usrednennyeSummy);
        }

        static void PrintDoubleArray(double[] massiv)
        {
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write($"{massiv[i]:F4}");
                if (i < massiv.Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        static void DelimNaSummu(double[] massiv)
        {
            var summa = 0.0;
            for (int i = 0; i < massiv.Length; i++)
                summa += massiv[i];

            if (Math.Abs(summa) > 0.000000001)
            {
                for (int i = 0; i < massiv.Length; i++)
                    massiv[i] = massiv[i] / summa;
            }
        }

        static double VychislitSummuProizvedeniy(double[] massiv)
        {
            var summa = 0.0;
            for (int i = 0; i < massiv.Length; i++)
                summa += massiv[i] * i;
            return summa;
        }

        static double[] VychislitUsrednennyeSummyKvadratov(double[] massiv)
        {
            var resultat = new double[massiv.Length];
            var summaKvadratov = 0.0;

            for (int k = 0; k < massiv.Length; k++)
            {
                summaKvadratov += massiv[k] * massiv[k];
                resultat[k] = summaKvadratov / (k + 1);
            }

            return resultat;
        }
    }
}
