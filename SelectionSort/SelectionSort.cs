using System;

namespace SelectionSort
{
    public class SelectionSort
    {

        public static void Main(String[] args)
        {
            int[] array = { 5, 6, 0, 1, 2, 4, 3 };

            Console.WriteLine("Original array: " + string.Join(" ", array));

            Console.Write("After sorting: ");
            foreach (var digit in Sort(array))
            {
                Console.Write(digit + " ");
            }
        }

        public static int[] Sort(int[] array)
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
