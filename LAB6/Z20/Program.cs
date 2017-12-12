using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z20
{
    class Program
    {
        static void Main(string[] args)
        {
            long a, b, p;
            a = Convert.ToInt64(Console.ReadLine());
            b = Convert.ToInt64(Console.ReadLine());
            p = 0;
            if (a > b)
            {
                while (b <= a)
                {
                    p = p + b*b;
                    b = b + 1;
                }
                Console.WriteLine(p);
            }
            else if (a < b)
            {
                while (a <= b)
                {
                    p = p + b*b;
                    b = b - 1;
                }
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
