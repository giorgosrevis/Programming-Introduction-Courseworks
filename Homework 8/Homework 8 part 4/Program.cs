using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            numbers(a);
        }

        private static int numbers(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Unreadable");

            }
            if (a % 2 == 1)
            {
                Console.WriteLine("Readable");
            }

            return a;
        }
    }
    
}
