using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 345;
            int f = 875;
            int k = 293;
            int c = Highest(x, f, k);

            Console.WriteLine(c);
            Console.WriteLine(Highest(x, f, k));

            int highest = int.MaxValue;
            int lowest = int.MinValue;
        }
       
    }
}
private static int Highest(int firstnumber, int secondnumber, int thirdnumber);
