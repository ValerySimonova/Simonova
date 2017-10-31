using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,result;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (b > 0)
            {
                Console.WriteLine("Значение b должно быть отрицательным");
                return;
            }
            else
            result = a * Math.Sqrt(-7*b);
                Console.WriteLine("{0:F4}", result);
        }
    }
}
