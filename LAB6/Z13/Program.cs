using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sum;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            sum = 0;
            if (a > b)
            {
                while (b <= a)
                {
                    sum = sum + b;
                    b = b + 1;
                }
                Console.WriteLine(sum);
            }
            else if (a < b)
            {
                while (a <= b)
                {
                    sum = sum + b;
                    b = b - 1;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
