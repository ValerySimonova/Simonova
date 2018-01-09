using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z27
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sum = 0;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (a < b)
            {
                while (a <= b)
                {
                    if (a % 7 == 0)
                    {
                        sum = a + sum;
                        a = a + 1;
                    }
                    else
                    {
                        a = a + 1;
                    }
                }
                Console.WriteLine("Ответ: " + sum);
            }
            else
            {
                while (b <= a)
                {
                    if (b % 7 == 0)
                    {
                        sum = b + sum;
                        b = b + 1;
                    }
                    else
                    {
                        b = b + 1;
                    }
                }
                Console.WriteLine("Ответ: " + sum);
            }
        }
    }
}
