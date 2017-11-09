using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Первое");
            }
            else
                if (a < b)
            {
                Console.WriteLine("Второе");
            }
            else
                Console.WriteLine("Равны");
        }
    }
}
