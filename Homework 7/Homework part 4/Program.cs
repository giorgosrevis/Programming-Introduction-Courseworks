using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Array = new int[,]
            {
               {1,2,3,4,5,6 },
               {7,8,9,10,11,12 },
               {13,14,15,16,17,18 },
                {19,20,21,22,23,24 },
                {25,26,27,28,29,30 }

            };
            Console.WriteLine(Array);

            for (int i = Array.Length - 1; i > -1; i--)
            {
                for (int j = Array.Length - 1; j > -1; j--)
                {
                    for (int k = Array.Length - 1; k > -1; k--)
                    {
                        for (int n = Array.Length - 1; n > -1; n--)
                        {
                            for (int l = Array.Length - 1; l > -1; l--)
                            {
                                Console.Write("|", i, j, k, l);
                            }
                            
                        }

                    }
                }
                
            }
        }
    }
}
