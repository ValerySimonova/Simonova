using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            X = Convert.ToDouble(Console.ReadLine());
            double result,Y, result1;
            Y = 61 - X;
            if (Y >= 0)
            {
                result1 =Math.Sqrt(Y);
                result = result1 * 3;
                Console.WriteLine("{0:F4}", result);
            }
            else
                Console.WriteLine("Значение Y должно быть неотрицательным");
        }
    }
}
