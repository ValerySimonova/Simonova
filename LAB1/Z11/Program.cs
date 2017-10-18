using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            double y;
            y = Convert.ToDouble(Console.ReadLine());
            double z;
            z = Convert.ToDouble(Console.ReadLine());
            String w;
            w = Console.ReadLine();
            Console.WriteLine(" < circle cx = \"{0}\" cy = \"{1}\"\n r = \"{2}\" fill = \"{3}\" /> ",x,y,z,w);
           
        }
    }
}
