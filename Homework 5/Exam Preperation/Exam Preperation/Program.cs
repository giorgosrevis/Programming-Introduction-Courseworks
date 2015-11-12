using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 digits");


            int[] array1 = new int[10];

            int min = int.MaxValue;
            int max = int.MinValue;


            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (max < array1[i])
                    {
                        max = array1[i];
                    }
                }
                if (i % 2 != 0)
                {
                    if (min > array1[i])
                    {
                        min = array1[i];
                    }
                }
            }
            Console.WriteLine("Max number is:" + max);
            Console.WriteLine("Min number is" + min);

        }
    }
}
