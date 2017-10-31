using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z36
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,d,e;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Math.Sqrt(Math.Pow((b-a),2)+ Math.Pow((d - c), 2));
            Console.WriteLine(e);
        }
    }
}