using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z25
{
    class Program
    {
        static void Main(string[] args)
        {
            double Y, I, N;
            I = 0;
            N = 0;
            Y = Convert.ToDouble(Console.ReadLine());
            if (Y > 15 || Y < 0)
            {
                Console.WriteLine("Значение Y должно быть в интервале [0, 15]");
                return;
            }
            N = N - Y;
            while (N < 0)
            {
                Console.Write("#");
                N = N + 1;
            }
            I = 15 - Y;//15-3=12
            while (I > 0)
            {
                Console.Write(".");
                I = I - 1;
            }
        }
    }
}
