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

            int[,] OurArray = new int[,]
            {
                {32,26,7,597,562,575,434,8565,4313,64,4,6 },

                {2,3,43,6,43,23,6,88,4,42,3,78 }
            };


            for (int i = 0; i < OurArray.GetLength(0); i++)
            {
                for (int j = 0; j < OurArray.GetLength(0); j++)
                {
                    if (OurArray[i,j]%2==0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            ;
            

            
           


        }
    }
}
