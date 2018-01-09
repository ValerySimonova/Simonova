using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z32
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int i;
            string c;
            Console.Write("Введите длину: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите символ: ");
            c = Console.ReadLine();
            if (a < 0)
            {
                Console.WriteLine("Высота должна быть положительной");
                return;
            }
            if (b < 0)
            {
                Console.WriteLine("Ширина должнна быть положительной");
                return;
            }
            else
            {
                for (i = 0; i < b; i++)
                {
                    for (int k = 0; k < a; k++)
                    {
                        Console.Write(c);
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
