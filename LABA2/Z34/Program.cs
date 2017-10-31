using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z34
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = 3*Math.Sin(2*Math.PI*a/180)*Math.Cos(3* Math.PI * b / 180);
            Console.WriteLine(c);
        }
    }
}