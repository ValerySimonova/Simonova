using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z19
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, i, c;
            A = 1;
            i = 0;
            c = 0;
            while (A<=83 || A>=199)
            {
                A = Convert.ToDouble(Console.ReadLine());
                if (A<=83)
                {
                    i = i + 1;
                }
                else if (A>=199)
                {
                    c = c + 1;
                }
            }
            Console.WriteLine("Количество слева: "+i+", количество справа: "+c);
        }
    }
}
