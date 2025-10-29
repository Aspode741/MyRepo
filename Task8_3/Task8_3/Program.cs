using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого ферзя");
            var whiteQueenPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черного ферзя");
            var blackQueenPosition = Console.ReadLine();

            if (whiteQueenPosition == blackQueenPosition)
            {
                Console.WriteLine("Ферзи не могут стоять на одной клетке");
                return;
            }

            int whiteQueenV, whiteQueenH;
            int blackQueenV, blackQueenH;

            DecodePosition(whiteQueenPosition, out whiteQueenV, out whiteQueenH);
            DecodePosition(blackQueenPosition, out blackQueenV, out blackQueenH);

            if (IsUnderStrikeByQueen(whiteQueenPosition, blackQueenPosition) ||
                IsUnderStrikeByQueen(blackQueenPosition, whiteQueenPosition))
                Console.WriteLine("Ферзи бьют друг друга");
            else
                Console.WriteLine("Ферзи не бьют друг друга");
        }

        static void DecodePosition(string position, out int vert, out int hor)
        {
            vert = (int)position[0] - 0x60;
            hor = int.Parse(position[1].ToString());
        }

        static bool IsUnderStrikeByQueen(string position, string queenPosition)
        {
            int pV, pH, qV, qH;

            DecodePosition(position, out pV, out pH);
            DecodePosition(queenPosition, out qV, out qH);

            return pV == qV ||
                   pH == qH ||
                   Math.Abs(pV - qV) == Math.Abs(pH - qH);
        }
    }
}