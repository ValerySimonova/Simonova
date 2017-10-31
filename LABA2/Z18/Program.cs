using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z18
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = a * b + a * c + b * c;
            Console.WriteLine("{0:F0}", d);
        }
    }
}
