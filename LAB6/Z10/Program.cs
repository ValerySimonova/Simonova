using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = 100;
            b = 0;
            while (a <= 500)
            {
                b= a+b;
                Console.Write(b+ " ");
                a = a + 1;
            }
            Console.WriteLine("Ответ:"+b);
        }
    }
}
