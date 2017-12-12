using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,c;
            a = 20;
            b = 0;
            while (a <= 40)
            {
                c = a * a * a;
                b = c + b;
                a = a + 1;
            }
            Console.WriteLine(b);
        }
    }
}
