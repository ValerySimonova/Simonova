using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z7
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
                while (a >= b)
                {
                    Console.Write(a);
                    a = a - 1;
                }
            }
            else
            {
                while (a <= b)
                {
                    Console.Write(a);
                    a = a + 1;
                }
            }
        }
    }
}
