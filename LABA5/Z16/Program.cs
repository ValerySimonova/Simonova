using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z16
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, max;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
            if (x > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }
            if (max > z)
            {
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine(max);
            }
        }
    }
}
