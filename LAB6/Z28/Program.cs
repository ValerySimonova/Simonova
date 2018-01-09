using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, i = 1;
            Console.Write("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Значение не должно быть отрицательным");
            }
            while (i <= a)
            {
                if (a % i == 0)
                {
                    Console.Write(i + " ");
                    i = i + 1;
                }
                else
                {
                    i = i + 1;
                }
            }
        }
    }
}
