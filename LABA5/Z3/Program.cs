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
            double b;
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                b = Math.Sqrt(a);
                Console.WriteLine(b);
            }
            else if (a < 0)
            {
                b = a*a;
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
