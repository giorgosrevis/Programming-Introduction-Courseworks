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
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

           

            
            Console.WriteLine(calculation(x, n));
        }
        static int calculation(int firstnumber, int secondnumber)
        {

            int result = firstnumber + secondnumber;
            return result;
        }

    }

}



