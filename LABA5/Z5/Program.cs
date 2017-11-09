using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceInKm, distanceInFeet, d;
            distanceInKm = Convert.ToDouble(Console.ReadLine());
            distanceInFeet = Convert.ToDouble(Console.ReadLine());
            d = distanceInFeet * 0.305;
            if (distanceInKm > 0)
            {
                if (d > 0)
                {
                    if (distanceInKm > d)
                    {
                        Console.WriteLine("Расстояние в футах меньше");
                    }
                    else if (distanceInKm < d)
                    {
                        Console.WriteLine("Расстояние в километрах меньше");
                    }
                    else
                    {
                        Console.WriteLine("Равны");
                    }
                }
                else
                {
                    Console.WriteLine("Значение distanceInFeet должно быть неотрицательным");
                }
            }
            else
            {
                Console.WriteLine("Значение distanceInKm должно быть неотрицательным");
            }

        }
    }
}