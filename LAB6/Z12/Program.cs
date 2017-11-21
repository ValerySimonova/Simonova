using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=-10, b, sum=0;
            b = Convert.ToDouble(Console.ReadLine());
            if (b <= 10000 && b >= -10)
            {
                while (a <= b)
                {
                    sum = sum + a;
                    a = a + 1;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
