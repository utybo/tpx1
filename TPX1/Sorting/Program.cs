using System;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        
        public static bool Sorted(int[] arr)
        {
            bool sorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
                if (sorted && arr[i] > arr[i + 1]) sorted = false;
            }

            Console.WriteLine();
            return sorted;
        }
        
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void BogoSort(int[] arr)
        {
            while (!Sorted(arr))
            {
                for (int i = 0; i < new Random().Next(100); i++)
                {
                    Swap(arr, new Random().Next(arr.Length), new Random().Next(arr.Length));
                }
            }
        }

        public static void SlowSort(int[] array)
        {
            while (!Sorted(array))
            {
                SlowSortHandler(0, array.Length - 1, array);
            }
        }

        public static void SlowSortHandler(int i, int j, int[] array)
        {
            if (i >= j)
                return;
            
            Console.WriteLine($"Testing with {i},{j}");

            int k = (i + j) / 2;
            
            SlowSortHandler(i, k, array);
            SlowSortHandler(k+1, j, array);

            if (array[k] > array[j])
            {
                Swap(array, k, j);
                Console.WriteLine($"Swapped {array[k]} and {array[j]}");
            }
            
            SlowSortHandler(k, j - 1, array);
        }
    }
}