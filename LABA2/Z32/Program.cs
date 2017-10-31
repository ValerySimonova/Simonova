using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z32
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            b = 12*a*a+7*a-16;
            Console.WriteLine(b);
        }
    }
}