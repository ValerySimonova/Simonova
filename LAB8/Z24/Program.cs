﻿using System;
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
            int i, L, j, I;

            j = 0;
            i = 0;
            I = 0;
            int n = 0;


            Console.Write(" Введите данные   ");
            String Q = Console.ReadLine();

            String[] arr = Q.Split(' ');
            L = arr.Length;// dlinna massiva
            int[] arr2 = new int[L];

            //////////
            while (I < L)
            {
                while (L > i)
                {
                    int a = Convert.ToInt32(arr[I]);
                    int b = Convert.ToInt32(arr[i]);
                    if (a == b)
                    {
                        j = j + 1;
                        arr2[I] = j;
                    }
                    i = i + 1;

                }
                i = 0;
                I = I + 1;
                j = 0;
                n = n + 1;


            }
            i = 0;
            while (i < L)
            {
                Console.Write(arr2[i]);
                i++;

            }
        }
    }
}
