using System;

namespace SelectionSort
{
    public class SelectionSort
    {

        public static void Main(String[] args)
        {
            int[] array = { 5, 6, 0, 1, 2, 4, 3 };
            foreach (var digit in selectionSort(array))
            {
                Console.WriteLine(digit + " ");
            }
        }

        public static int[] selectionSort(int[] array)
        {
            int min, temp;
            for (int i = 0; i < array.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}
