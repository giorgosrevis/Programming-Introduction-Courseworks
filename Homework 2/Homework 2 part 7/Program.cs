using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_part_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string No1 = (Console.ReadLine());

            string No2 = (Console.ReadLine());

            if (No2.Contains(No1))

            {
                Console.WriteLine("It does");
            }
            else
            {
                Console.WriteLine("It doesn't");
            }
        }
    }
}
