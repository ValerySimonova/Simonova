using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z10
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
                a = a * a;
            }
            if (b > 0)
            {
                b = b * b;
            }
            if (c > 0)
            {
                c = c * c;
            }
            Console.WriteLine("{0}; {1}; {2}", a, b, c);
        }
    }
}
