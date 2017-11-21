using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z21
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 1) && (x <= 2) && (y <= 4))
            {
                Console.WriteLine("Точка с координатами (х,у) принадлежит области");
            }
            else
            {
                Console.WriteLine("Точка с координатами (х,у) не принадлежит области");
            }
        }
    }
}
