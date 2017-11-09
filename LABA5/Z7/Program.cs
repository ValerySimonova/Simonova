using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z7
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, E, S1, S2;
            R = Convert.ToDouble(Console.ReadLine());
            E = Convert.ToDouble(Console.ReadLine());
            S1 = Math.PI * R * R;
            S2 = E * E;
            if (R > 0)
            {
                if (E > 0)
                {
                    if (S1>S2)
                    {
                        Console.WriteLine("Площадь круга {0} больше площади квадрата {1}", S1,S2);
                    }
                    else if (S1<S2)
                    {
                        Console.WriteLine("Площадь квадрата {0} больше площади круга {1}", S2,S1);
                    }
                    else
                    {
                        Console.WriteLine("Равны");
                    }
                }
                else
                {
                    Console.WriteLine("Сторона квадрата должна быть положительна");
                }
            }
            else
            {
                Console.WriteLine("Радиус должен быть положительным");
            }
        }
    }
}
