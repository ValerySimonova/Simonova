using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sc, Ss, a, b;
            Sc = Convert.ToDouble(Console.ReadLine());
            Ss = Convert.ToDouble(Console.ReadLine());
            a = 2 * Math.Sqrt(Sc / Math.PI);
            b = Math.Sqrt(Ss * 2);
            if (Sc > 0)
            {
                if (Ss > 0)
                {
                    if (a >= b)
                    {
                        Console.WriteLine("Круг уместится в квадрате");
                    }
                    else
                    {
                        Console.WriteLine("Круг не поместится в квадрате");
                    }
                }
                else
                {
                    Console.WriteLine("Площадь квадрата должна быть положительной");
                }
            }
            else
            {
                Console.WriteLine("Площадь круга должна быть положительной");
            }


        }
    }
}
