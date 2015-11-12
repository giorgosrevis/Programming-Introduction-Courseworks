using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int m = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[,] OurArray = new int[x,k];

            OurArray[ x,k ] = m;
            OurArray[x, k] = m;
            OurArray[x, k] = m;
            OurArray[x, k] = m;

            for (int i = 0; i < OurArray.GetLength(0); i++)
            {
                for (int j = 0; j < OurArray.GetLength(0); j++)
                {
                    for (int g = 0; g < OurArray.GetLength(0); g++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
                

        }
    }
}
