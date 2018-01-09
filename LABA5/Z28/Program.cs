using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("Введите координату a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату d: ");
            d = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Значение А должно быть положительным");
                return;
            }
            if (b < 0)
            {
                Console.WriteLine("Значение B должно быть положительным");
                return;
            }
            if (c < 0)
            {
                Console.WriteLine("Значение C должно быть положительным");
                return;
            }
            if (d < 0)
            {
                Console.WriteLine("Значение D должно быть положительным");
                return;
            }
            if ((a < c && b < d) || (a < d && b < c))
            {
                Console.WriteLine("Размещение возможно");
                return;
            }
            Console.WriteLine("Размещение не возможно");
        }
    }
}
