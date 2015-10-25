using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1-9 to get your result");

            int A = int.Parse(Console.ReadLine());

            if (A >= 3 && A <= 3)
            {

                Console.WriteLine(A * 5);

            }

            if (A >= 4 && A <= 6) ;

            {

                Console.WriteLine(A * 10);
            }

            if (A >= 7 && A <= 9) ;

            {

                Console.WriteLine(A*50);

            }
        }

    }
}
