﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z29
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, i = 1, b = 0;
            Console.Write("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Значение не должно быть отрицательным");
            }
            while (i <= a)
            {
                if (a % i == 0)
                {
                    b=b+1;
                    i=i+1;
                }
                else
                {
                    i=i+1;
                }
            }
            if (b == 2)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
        }
    }
}
