using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "парапсихолог"; //0п1а2р3а4п5с6и7х8о9л10о11г12

            string pirog = x.Substring(0, 1) +
                              x.Substring(6, 1) +
                              x.Substring(2, 1) +
                              x.Substring(10, 1) +
                              x.Substring(11, 1);

            string hrap = x.Substring(7, 1) +
                          x.Substring(2, 1) +
                          x.Substring(1, 1) +
                          x.Substring(0, 1);

            Console.WriteLine("пирог = " + pirog);
            Console.WriteLine("храп = " + hrap);

        }
    }
}
