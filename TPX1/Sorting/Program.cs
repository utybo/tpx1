using System;

namespace Sorting
{
    class Program
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
    }
}