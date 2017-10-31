using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z37
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1,t1,v2,t2,a,b;
            v1= Convert.ToDouble(Console.ReadLine());
            t1 = Convert.ToDouble(Console.ReadLine());
            v2 = Convert.ToDouble(Console.ReadLine());
            t2 = Convert.ToDouble(Console.ReadLine());
            if (v1>0)
            {
                if (v2 > 0)
                {
                    a = v1 + v2;
                    b = (t1 * v1 + t2 * v2) / (v1 + v2);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else
                    Console.WriteLine("Объем должен быть неотрицательным");
            }
            else
                Console.WriteLine("Объем должен быть неотрицательным");
        }
    }
}