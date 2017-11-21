using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            int i = 0;
            String b;
            b = Console.ReadLine();
            Console.Write("\"");
            while (i < a)
            {
                Console.Write(b);
                i = i + 1;
            }
            Console.Write("\"");
        }
    }
}
