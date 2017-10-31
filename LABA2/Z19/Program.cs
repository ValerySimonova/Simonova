using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z19
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a >= 0)
            {
                if (b > 0)
                {
                    d = a*b+c/2*b*b;
                    Console.WriteLine("{0:F4}", d);
                }
                else
                    Console.WriteLine("Время должно быть положительным");
            }
            else
                Console.WriteLine("Начальная скорость должно быть неотрицательна");
        }
    }
}
