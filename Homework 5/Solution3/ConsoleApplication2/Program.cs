using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];

           

            for (int i = 0; i < 10; i++)
            {
               
                array1[i] = int.Parse(Console.ReadLine());


            }
            printarrayreverse(array1);
       }
        private static void printarrayreverse(int[]array1)
        {
            for (int i = array1.Length - 1;i> -1; i--)
            {
                Console.WriteLine(array1[i]);
            }
        }


    } 
}
