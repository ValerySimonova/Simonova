using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z33
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
            {
                b = Math.Sqrt(Math.Pow((6350 + a), 2) - 6300 * 6300);
                Console.WriteLine(b);
            }
            else
                Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна");
        }
    }
}
