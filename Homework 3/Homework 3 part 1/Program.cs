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
            Console.WriteLine("Enter a number from 0-9 to get a letter from A to J");

            int letter = int.Parse(Console.ReadLine());

            switch (letter)
            {
                case 0: Console.WriteLine("A");
                    break;

                case 1: Console.WriteLine("B");
                    break;

                case 2: Console.WriteLine("C");
                    break;

                case 3: Console.WriteLine("D");
                    break;

                case 4: Console.WriteLine("E");
                    break;

                case 5: Console.WriteLine("F");
                    break;

                case 6: Console.WriteLine("G");
                    break;

                case 7: Console.WriteLine("H");
                    break;

                case 8: Console.WriteLine("I");
                    break;

                case 9: Console.WriteLine("J");
                    break;

                
            }
        }
    }
}
