using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        if ((a == b) || (a == c) || (b == c))
                        {
                            Console.WriteLine("Треугольник является равнобедренным");
                        }
                        Console.WriteLine("Значение C должно быть неотрицательным");
                    }
                    Console.WriteLine("Значение B должно быть неотрицательным");
                }
                Console.WriteLine("Значение A должно быть неотрицательным");
            }
            Console.WriteLine("Треугольник не является равнобедренным");
        }
    }
}
