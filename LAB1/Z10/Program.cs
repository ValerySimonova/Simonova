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
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            double y;
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("INSERT INTO points(x, y) VALUES('{0}', '{1}')",x,y);
        }
    }
}
