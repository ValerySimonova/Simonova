using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocityInKmH, velocityInMS, d;
            velocityInKmH = Convert.ToDouble(Console.ReadLine());
            velocityInMS = Convert.ToDouble(Console.ReadLine());
            d = velocityInMS * 3.6;
            if (velocityInKmH > 0)
            {
                if (d > 0)
                {
                    if (velocityInKmH > d)
                    {
                        Console.WriteLine("{0} м/с меньше {1} км/ч", velocityInMS, velocityInKmH);
                    }
                    else if (velocityInKmH < d)
                    {
                        Console.WriteLine("{0} м/с меньше {1} км/ч",velocityInKmH ,velocityInMS );
                    }
                    else
                    {
                        Console.WriteLine("Равны");
                    }
                }
                else
                {
                    Console.WriteLine("Значение velocityInMS должно быть неотрицательным");
                }
            }
            else
            {
                Console.WriteLine("Значение velocityInKmH должно быть неотрицательным");
            }

        }
    }
}