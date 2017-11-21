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
            double a,b=0;
            a = Convert.ToDouble(Console.ReadLine());
            if (a <= 500 && a >= -100)
            {
                while (a <= 500)
                {
                    b = b + a;
                    a = a + 1;
                }
                Console.WriteLine(b);
            }
        }
    }
}
