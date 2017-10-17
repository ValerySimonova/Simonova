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
            String first;
            first = Console.ReadLine();
            Console.WriteLine("Программирование это " + first + "! ");
            Console.Write("Программирование это ");
            Console.Write(first);
            Console.WriteLine("!");
            Console.WriteLine("Программирование это {0}!", first);
        }
    }
}
