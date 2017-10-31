using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z17
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,d;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c= Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                if (b > 0)
                {
                    d = c / (a + b);
                    Console.WriteLine("{0:F4}", d);
                }
                else
                    Console.WriteLine("Значение b должно быть положительным");
            }
            else
                Console.WriteLine("Значение a должно быть положительным");
        }
    }
}
