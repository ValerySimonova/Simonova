using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double z;
            z = double.Parse(a);
            double b, c,d;
            c = Math.PI;
            b = Math.Cos(z * c / 180);
            d = 5 * b;
            Console.WriteLine(d);
        }
    }
}
