using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(c * Math.PI / 180));
            Console.WriteLine(d);
        }
    }
}
