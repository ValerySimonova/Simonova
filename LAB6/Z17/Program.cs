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
            double A, i, c;
            A = 1;
            i = 0;
            c = 0;
            while (A != 0)
            {
                A = Convert.ToDouble(Console.ReadLine());
                i = i + 1;
                c = c + A;
            }
            Console.WriteLine("Сумма чисел: "+c+", Количество чисел: " +i);
        }
    }
}
