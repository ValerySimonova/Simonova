﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" введите данные ");
            string Q = Console.ReadLine();
            String A, B;
            int z;
            z = Q.Length; 
            B = Q.Substring(z - 1, 1);
            if (B != "\"")
            {
                Console.Write(" Строка должна начинаться и заканчиваться кавычкой ");
                return;
            }
            A = Q.Substring(0, 1);
            if (A != "\"")
            {
                Console.Write(" Строка должна начинаться и заканчиваться кавычкой ");
                return;
            }
            string s2 = Q.TrimStart("\"".ToCharArray()); 
            string c = s2.TrimEnd("\"".ToCharArray()); 
            string w = c.Trim(); 

            Console.Write(w);
        }
    }
}
