﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z18
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            A = Convert.ToDouble(Console.ReadLine());
            if (A <= 9999 && A >= 1000)
            {
                if (A % 10 == (A % 1000 - A % 100) / 100)
                {
                    Console.WriteLine("Равно");
                }
                else
                {
                    Console.WriteLine("Не равно");
                }
            }
            else
            {
                Console.WriteLine("Значение A должно быть в интервале [1000, 9999]");
            }
        }
    }
}

