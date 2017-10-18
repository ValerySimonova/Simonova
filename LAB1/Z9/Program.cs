using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("SELECT first_name, last_name, group\n" +
                "FROM students WHERE student_id =" + "'"+A +"'");
        }
    }
}
