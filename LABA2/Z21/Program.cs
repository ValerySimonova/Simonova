using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                if (b != 0)
                {
                    c=1/a+1/b;
                    Console.WriteLine("{0:F4}", c);
                }
                else
                    Console.WriteLine("Значение r2 должно быть не равно нулю");
            }
            else
                Console.WriteLine("Значение r1 должно быть не равно нулю");
        }
    }
}
