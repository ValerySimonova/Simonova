using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z29
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            a = Convert.ToDouble(Console.ReadLine());
            b=a+5;
            c = a - 5;
            if (a>0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        d=(b+c)/(2*Math.Sqrt(a));
                        Console.WriteLine("{0:F4}", d);
                    }
                    else
                        Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                }
                else
                    Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
            }
            else
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
        }
    }
}
