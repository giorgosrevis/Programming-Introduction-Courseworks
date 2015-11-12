using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers");
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Calculate(x, n*100);
        }
        static void Calculate(int firstnumber, int secondnumber)
        {
            Console.WriteLine(firstnumber + secondnumber);

        }


    }
}
