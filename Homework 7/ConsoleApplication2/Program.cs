using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        
        
            const int row = 30;
            const int column = 10;

            static void Main(string[] args)
        {
                int[,] array = new int[row, column];
                Random rand = new Random();

                for (int i = 0; i < column; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        array[i, j] = rand.Next(0, 10);

                    }
                }


                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j].ToString() + " ");
                    }
                    Console.WriteLine("");
                }
            }
    }
}
