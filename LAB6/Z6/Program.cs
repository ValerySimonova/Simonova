using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6
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
                while (a <= b)
                {
                    Console.WriteLine(b);
                    b = b + 1;
                }
            }
            else
            {
                while (a <= b)
                {
                    Console.WriteLine(a);
                    a=a + 1;
                }
            }
        }
    }
}
