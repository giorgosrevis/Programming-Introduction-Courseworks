using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(sum(a, b, c));

            sum(a, b, c);
        }

        static int sum(int a, int b, int c)
        {
            int sum = a * b * c;
            return sum;

        }
    }
    
}
