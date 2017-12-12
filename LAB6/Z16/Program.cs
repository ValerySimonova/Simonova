using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z16
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, b, c;
            n = Convert.ToDouble(Console.ReadLine());
            b = 1;
            c = 0;
            while (b <= n)
            {
                c = c + 1 / b;
                b = b + 1;
            }
            Console.WriteLine(c);
        }
    }
}
