using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ:  ");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 30;
            while (i <= 40)
            {
                if (x == i)
                {
                    Console.WriteLine(i + "+");
                }
                else
                {
                    Console.WriteLine(i+ "-");
                }
                i = i + 1;
            }
        }
    }
}
