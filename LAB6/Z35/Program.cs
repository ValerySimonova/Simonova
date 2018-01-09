using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z35
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            string a;
            int i, k;
            Console.Write("Введите cимвол: ");
            a = Console.ReadLine();
            Console.Write("Введите высоту: ");
            b = Convert.ToDouble(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("высота не должна быть отрицательной");
            }
            for (i = 0; i < b; i++)
            {
                for (k = 0; k <= i; k++)
                {
                    Console.Write(a);
                }
                Console.Write("\n");
            }
        }
    }
}
