using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_part_2
{
    class Program
    {
        static void Main(string[] args)
        { int num = int.Parse(Console.ReadLine());

            int first = 1;

            Console.Write("{0}", first);

            int second = 2;

            Console.Write("{0}", first);

            int sum = 0;

            while (sum <= num)

            {
                sum = first + second;

                Console.Write("{0}", sum);

                first = second;
                second = sum;

            }
        }
    }
}
