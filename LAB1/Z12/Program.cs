using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z12
{
    class Program
    {
        static void Main(string[] args)
        {
            String ID;
            ID = Console.ReadLine();
            String Password;
            Password = Console.ReadLine();
            String Host;
            Host = Console.ReadLine();
            String Port;
            Port = Console.ReadLine();
            String Database;
            Database = Console.ReadLine();
            Console.WriteLine("User ID = {0}; Password = {1};\n" +
                "Host = {2}; Port = {3}; Database = {4}; ", ID, Password, Host, Port, Database);
        }
    }
}
