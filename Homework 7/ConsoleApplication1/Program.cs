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

            int RandomNumber = int.Parse(Console.ReadLine());

            int[,] array = new int[RandomNumber, RandomNumber];

            Random Number = new Random();

            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Number.Next(0, 20);

                    sum += array[i, j];

                    if (array[i,j]%2==0)
                    {
                        Console.WriteLine(array[i,j]);
                    }


                }
            }
        }




    }

}
    

