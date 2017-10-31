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
            double a, b, c, d, e,s,t;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = a * d * d + b * d + c;
            if (c != 0)
            {
                s = Math.Sqrt(c);
                if (s > 0)
                {
                    t=1/s;
                    Console.WriteLine("{0:F4}", t);
                }
                else
                    Console.WriteLine("Знаменатель не может быть равен нулю");
            }
            else
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
        }
    }
}
