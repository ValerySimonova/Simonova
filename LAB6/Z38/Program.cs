using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z38
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, i;
            Console.Write("Введите первое число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                i = a;
                a = b;
                b = i;
            }
            for (i = a; i <= b; i++)
            {
                if ((i % 2 != 0 && i != b) && (i % 2 != 0 && i != b - 1))
                {
                    Console.Write(i + ", ");
                }
                if ((i % 2 != 0 && i == b) || (i % 2 != 0 && i == b - 1))
                {
                    Console.Write(i + "\n");
                }
            }
        }
    }
}
