using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z17
{
    class Program
    {
        static void Main(string[] args)
        {
            double M, P;
            M = Convert.ToDouble(Console.ReadLine());
            P = Convert.ToDouble(Console.ReadLine());
            if (P == 0)
            {
                Console.WriteLine("Значение P должно быть не равно нулю");
            }
            else
            {
                if (M % P == 0)
                {
                    Console.WriteLine(M);
                }
                else
                {
                    Console.WriteLine("M не делится нацело на P");
                }
            }

        }
    }
}
