using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preperation_subject_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array1 = new int[n, n];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int max = int.MinValue;
            int min = int.MaxValue;
                int minCol = 0;
            int minRow = 0;
            int maxCol = 0;
            int maxRow = 0;

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    if (max < array1[i,j])
                    {
                        max = array1[i, j];
                        maxCol = j;
                        maxRow = i;
                        if (min > array1[i,j])
                        {
                            min = array1[i,j];
                            minCol = j;
                            minRow = i;
                        }
                        Console.Write(array1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }




        }
    }
}
