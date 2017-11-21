using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
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
                Console.WriteLine(a);
                a = a + 1;
            }
            Console.WriteLine("Значение A должно быть не больше значения B");
        }
    }
}
