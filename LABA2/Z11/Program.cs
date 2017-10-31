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
            double X;
            X = Convert.ToDouble(Console.ReadLine());
            double result;
            if (X >= 0)
            {
                result = Math.Sqrt(X);
                Console.WriteLine("{0:F4}", result);
            }
            else
                Console.WriteLine("Значение X должно быть неотрицательным");
        }
    }
}
