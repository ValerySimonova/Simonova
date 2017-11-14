using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if ((a==b)||(a==c)||(b==c))
            {
                Console.WriteLine("Среди чисел есть равные");
            }
            Console.WriteLine("Числа не равны друг другу");
        }
    }
}
