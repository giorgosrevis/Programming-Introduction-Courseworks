using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] OurArray1 = new int[,] {
                  {1,2,3,4,5,6,7,8,9},
                  { 2,3,4,5,6,7,8,9,10},
                  { 3,4,5,6,7,8,9,10,11},
                  { 4,5,6,7,8,9,10,11,12}

            };

            for (int i = 0; i < OurArray1.GetLength(0); i++)
            {

                foreach (var Numbers in OurArray1)
                {

                    Console.WriteLine(OurArray1.GetLength(0));
                }
            }
        }
    }
}
