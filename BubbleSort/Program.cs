using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[] { 8,9,10,5,6,2,1};
            Console.WriteLine("Existing massive: " + string.Join(" ",massive));
            Console.WriteLine("Result of bubble sort: "+ string.Join(" ", BubbleSortMethod(massive)));
            Console.ReadKey(true);
        }

        public static int[] BubbleSortMethod(int[] massive)
        {
            int temp;
            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = 0; j < massive.Length-1-i; j++)
                {
                    if (massive[j] > massive[j+1])
                    {
                        temp = massive[j];
                        massive[j] = massive[j+1];
                        massive[j+1] = temp;
                    }
                }
            }
            return massive;
        }
    }
}
