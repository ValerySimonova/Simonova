﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z33
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            int i;
            Console.Write("Введите длину: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("длина должна быть положительной");
            }
            if (a == 0)
            {
                return;
            }
            for (i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Console.Write("+");
                }
                if (i == a - 1)
                {
                    Console.WriteLine("+");
                }
                if (i >= 1 && i < a - 1)
                {
                    Console.Write("-");
                }
            }
            for (i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Console.Write("|");
                }
                if (i == a - 1)
                {
                    Console.WriteLine("|");
                }
                if (i >= 1 && i < a - 1)
                {
                    Console.Write(".");
                }
            }
            for (i = 0; i < a; i++)
            {
                if (i == 0)
                {
                    Console.Write("+");
                }
                if (i == a - 1)
                {
                    Console.WriteLine("+");
                }
                if (i >= 1 && i < a - 1)
                {
                    Console.Write("-");
                }
            }
        }
    }
}
