using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z30
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,d,e;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c =a*Math.PI/180;
            d = b * Math.PI / 180;
            e = Math.Sin(c)*Math.Cos(d)+ Math.Sin(d) * Math.Cos(c);
            Console.WriteLine(e);
        }
    }
}