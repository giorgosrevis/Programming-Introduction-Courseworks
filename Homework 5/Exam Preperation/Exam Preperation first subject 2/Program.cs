using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preperation_first_subject_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            int[] array2 = new int[N];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    
                    if (array1[i] == array2[j])
                    {
                        Console.WriteLine(array1[i]);
                    }
                }
            }
        }
    }
}
