using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = 1;
            b = 7;
            while (a <= 9)
            {
                Console.WriteLine("{0} x {1}",a,b);
                a = a + 1;
            }
        }
    }
}
