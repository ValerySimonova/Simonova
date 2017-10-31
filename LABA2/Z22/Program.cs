using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z22
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                if (b < 90)
                {
                    c = a*9.8067*Math.Cos(b*Math.PI/180);
                    Console.WriteLine(c);
                }
                else
                    Console.WriteLine("0");
            }
            else
                Console.WriteLine("Масса должна быть положительной");
        }
    }
}
