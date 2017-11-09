using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Максимальное {0}, минимальное {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("Максимальное {0}, минимальное {1}", b, a);
            }
            else
            {
                Console.WriteLine("Равны");
            }
        }
    }
}
