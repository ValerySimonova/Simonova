using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,d,e;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                if (d != 0)
                {
                    e = (a*b+b*c)/(a*d);
                    Console.WriteLine("{0:F4}", e);
                }
                else
                    Console.WriteLine("Значение d должно быть не равно нулю");
            }
            else
                Console.WriteLine("Значение a должно быть не равно нулю");
        }
    }
}