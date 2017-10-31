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
            string a;
            a = Console.ReadLine();
            double z;
            z = double.Parse(a);
            double b,c;
            c = Math.PI;
            b = Math.Sin(z*c/180);
            Console.WriteLine(b);
        }
    }
}
