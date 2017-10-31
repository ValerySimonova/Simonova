using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int z;
            z = int.Parse(a);
            int b;
            b = z % 360;
            Console.WriteLine(b);
        }
    }
}
