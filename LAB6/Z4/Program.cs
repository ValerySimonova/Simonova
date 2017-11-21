using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            while (a <= b)
            {
                Console.Write(b);
                b = b - 1;
            }
            Console.WriteLine("Значение A должно быть не больше значения B");
        }
    }
}
