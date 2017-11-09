using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if ((a < b)&& (b < c))
            {
                Console.WriteLine("\"Выполняется\"");
            }
            Console.WriteLine("\"Не выполняется\"");
        }
    }
}
