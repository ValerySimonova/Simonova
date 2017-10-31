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
            double a, b,c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Math.Sin(a*Math.PI/180);
            c = Math.Sqrt(1 - b * b);
            Console.WriteLine(c);
        }
    }
}
