using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = PrintName();
            Console.WriteLine("Hi, {0} !", name);
            PrintName();

        }

        private static string PrintName()
        {
            string name;
            Console.Write("Insert Name: ");
            name = Console.ReadLine();
            return name;
        }
    }
    
}
