using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d,e;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c >= 0)
                    {
                        d = a * b * b / 2;
                        e = a * 9.8067 * c;
                        Console.WriteLine("Кинетическая энергия составляет: {0:F4} Дж", d);
                        Console.WriteLine("Потенциальная энергия составляет: {0:F4} Дж", e);
                    }
                    else
                        Console.WriteLine("Значение height должно быть неотрицательным");
                }
                else
                    Console.WriteLine("Значение velocity должно быть положительным");
            }
            else
                Console.WriteLine("Значение mass должно быть положительным");
        }
    }
}
