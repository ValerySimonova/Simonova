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
            double x,y,a,b;
            x= Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (y >= 0)
            {
                a = x + Math.Sqrt(y);
                if (a >= 0)
                {
                    b = -5 * Math.Sqrt(a);
                }
                else
                    Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
            }
            else
                Console.WriteLine("Значение Y должно быть неотрицательным");
        }
    }
}
