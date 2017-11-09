using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                return;
            }
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = -b + Math.Sqrt(d);
                x2 = -b - Math.Sqrt(d);
                if (x1 == x2)
                {
                    Console.WriteLine("Уравнение {0}x^2 + {1}x + {2} = 0 имеет один корень", a, b, c);
                }
                else
                {
                    Console.WriteLine("У уравнения {0}x^2 + {1}x + {2} = 0 два вещественных корня", a, b, c);
                }
            }
            else
            {
                Console.WriteLine("Вещественных корней уравнения {0}x ^ 2 + {1}x + {2} = 0 нет", a, b, c);
            }
        }



    }
}

