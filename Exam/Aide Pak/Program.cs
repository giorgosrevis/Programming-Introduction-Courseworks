using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aide_Pak
{
    class Program
    {
        static void Main(string[] args)
        {
            int RandomNumber = int.Parse(Console.ReadLine());

            int[,] array = new int[RandomNumber, RandomNumber];

            int[] array2 = new int[RandomNumber*RandomNumber];

            Random Number = new Random();

            int sum = 0;
            int counter = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Number.Next(0,10);

                sum += array2[i];


            }

            Console.WriteLine(sum);

            for (int row = 0; row < array.GetLength(0); row++)

            {

                for (int col = 0; col < array.GetLength(1); col++)

                {

                    array[col , row] = array2[counter++];

                }
            }
            for (int row = 0; row < array.GetLength(0); row++)

            {

                for (int col = 0; col < array.GetLength(1); col++)

                {

                    Console.Write("\t"+array[row, col]);

                }

                Console.WriteLine();

            }
        }

    }
}
