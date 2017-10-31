using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            double b;
            if (a > -273.16)
            {
                b = a*1.8+32;
                Console.WriteLine("{0:F4}", b);
            }
            else
                Console.WriteLine("Температура должна быть выше абсолютного нуля");
        }
    }
}
