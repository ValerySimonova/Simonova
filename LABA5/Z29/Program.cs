using System;
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
            double x, y;
            Console.WriteLine("Введите координату x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y: ");
            y = Convert.ToDouble(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Коорлината Х должна быть положительной");
                return;
            }
            if (y < 0)
            {
                Console.WriteLine("Координата У должнабыть положительной");
                return;
            }
            if ((x >= 100 && x <= 190) && (y >= 100 && y <= 170))
            {
                Console.WriteLine("Точка внутри прямоугольника");
                return;
            }
            Console.WriteLine("Точка снаружи прямоугольника");
        }
    }
}
