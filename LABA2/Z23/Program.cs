using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z23
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                d = b * b - 4 * a * c;
                Console.WriteLine(d);
            }
            else
                Console.WriteLine("Данное уравнение не является квадратным");
        }
    }
}
