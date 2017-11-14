using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if ((a >-3)&&(a<5))
            {
                Console.WriteLine(a);
            }
            if ((b > -3) && (b < 5))
            {
                Console.WriteLine(b);
            }
            if ((c > -3) && (c < 5))
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("Числа не входят в интервал");
        }
    }
}
