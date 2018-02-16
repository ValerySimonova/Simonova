using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, i;
            i = 0;
            Console.Write(" Введите данные ");
            String a = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(a))
            {
                Console.Write("Строка пуста");
                return;
            }
            String[] arr = a.Split(' ');
            b = arr.Length;
            while (i < b)
            {
                Console.WriteLine(arr[i] + " " + i);
                i++;
            }
        }
    }
}
