using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = 100;
            b = 0;
            while (a <= 1000)
            {
                if (a%13==0)
                {
                    b = b + 1;
                }
                a = a + 1;
            }
            Console.WriteLine("Ответ:" + b);
        }
    }
}
