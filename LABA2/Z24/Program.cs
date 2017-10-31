using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z24
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        d = 9.8067*a*b/(c*c);
                        Console.WriteLine(d);
                    }
                    else
                        Console.WriteLine("Дистанция должна быть неотрицательной");
                }
                else
                    Console.WriteLine("Масса должна быть неотрицательной");
            }
            else
                Console.WriteLine("Масса должна быть неотрицательной");
        }
    }
}
