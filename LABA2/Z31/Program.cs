using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z31
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            b = 7 * a * a - 3 * a + 6;
            Console.WriteLine(b);
        }
    }
}