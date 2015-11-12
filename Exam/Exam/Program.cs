using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int RandomNumber = int.Parse(Console.ReadLine());

            int[,] array = new int[RandomNumber, RandomNumber];

            int[] array2 = new int[RandomNumber];

            Random Number = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = Number.Next(-100, 100);
            }

            for (int row = 0; row < array.GetLength(0); row++)

            {

                for (int col = 0; col < array.GetLength(1); col++)

                {

                    Console.Write(array[row, col]);

                }

                Console.WriteLine();

                for (int i = 0; i < array.GetLength(0); i++)

                {
                    for (int j = 0; j < array2.Length; j++)

                    {
                        array[i, j] = Number.Next(-100, 100);


                        for (int k = array.GetLength(0) - 1; i > -1; i--)

                        {
                            for (int l = array2.Length - 1; j > -1; j--)

                            {
                                array[i, i] = array2[j];




                            }

                        }
                    }
                }










            }

        }
    }
}
