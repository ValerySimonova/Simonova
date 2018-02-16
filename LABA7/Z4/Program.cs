using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Q = "abcdacadbacdaabaadc";
            Console.Write(" введите данные ");
            string a = Console.ReadLine();
            int i = 0, x = 0, b = 0, s = 0;
            s = a.Length;
            if (s != 2)
            {
                Console.Write("Вводимая строка должна содержать ровно 2 символа ");
            }

            while (i < 19)
            {
                x = Q.IndexOf(a, b);
                if (b == x)
                {
                    Console.Write(x + " ");
                }
                i = i + 1;
                b = b + 1;
            }
        }
    }
}
