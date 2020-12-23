using System;
using System.Linq;
using System.Threading;

namespace SortingVisualizer
{
    class Visualizer
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;
            int[] arr1 = new[] {0, 4568, -31, 6543, 8, 91, -4376, 967, 112, 534, 76975, 3298, 1367, -234, 984379};
            
            Console.WriteLine($"Sorting: BubbleSort | Change 0");
            DisplayArray(arr1, -1);
            SortAlgorithms.BubbleSort(arr1);
            
            Thread.Sleep(2000);
            Console.Clear();
            
            
            int[] arr2 = new[] {0, 4568, -31, 6543, 8, 91, -4376, 967, 112, 534, 76975, 3298, 1367, -234, 984379};
            
            Console.WriteLine($"Sorting: QuickSort | Change 0");
            DisplayArray(arr2, -1);
            SortAlgorithms.QuickSort(arr2);
            Console.CursorVisible = true;
        }
        
        public static void CleanDisplay(int[] ints)
        {
            var sum = ints.Sum();
            
            Console.SetCursorPosition(sum+3, 2);
            for (int k = 0; k < 10; k++)
                Console.Write(" ");
            Console.SetCursorPosition(0, 3);
            for (int k = 0; k < sum; k++)
                Console.Write(" ");
            Console.SetCursorPosition(0, 4);
            for (int k = 0; k < sum; k++)
                Console.Write(" ");
            Console.SetCursorPosition(0, 5);
            for (int k = 0; k < sum + 10; k++)
                Console.Write(" ");
        }
        
        public static void DisplayAssignement(int[] arr, int i, int value, ref int changes)
        {
            var temp = arr[i];
            arr[i] = value;
            
            changes++;
            Console.SetCursorPosition(29, 0);
            Console.Write(changes);
            
            var pos = DisplayArray(arr, i);
            CleanDisplay(pos);
            
            int left = 0;
            for (int k = 0; k <= i; k++)
                left += pos[k];
            Console.SetCursorPosition(left-1, 3);
            Console.Write("^");
            Console.SetCursorPosition(left-3, 4);
            Console.Write("was");
            var digitLeft = left - (temp.ToString().Length);
            Console.SetCursorPosition(digitLeft < 0 ? 0 : digitLeft, 5);
            Console.Write(temp);
            
            Thread.Sleep(400);
        }

        public static void DisplaySwap(int[] arr, int i, int j, ref int changes)
        {
            int temp = arr[i];
            DisplayAssignement(arr, i, arr[j], ref changes);
            DisplayAssignement(arr, j, temp, ref changes);
        }

        // Displays the inital state of the array arr and returns the coordinates of every value on the console
        public static int[] DisplayArray(int[] arr, int change)
        {
            int[] pos = new int[arr.Length];
            
            Console.SetCursorPosition(0, 2);

            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (change == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{arr[i]}");
                    Console.ResetColor();
                    Console.Write(", ");
                }
                else
                    Console.Write($"{arr[i]}, ");
                
                

                pos[i] = arr[i].ToString().Length + 2;
            }
            Console.Write("]");

            return pos;
        }
    }
}
