namespace SortingVisualizer
{
    public class SortAlgorithms
    {
        public static void BubbleSort(int[] arr)
        {
            bool swap = true;
            int changes = 0;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Visualizer.DisplaySwap(arr, i, i + 1, ref changes);
                        swap = true;
                    }
                }
            }
        }
        
        public static void QuickSort(int[] arr)
        {
            int changes = 0;
            
            QuickSortHandler(arr, 0, arr.Length - 1, ref changes);
        }

        private static void QuickSortHandler(int[] arr, int first, int last, ref int changes)
        {
            if (first < last)
            {
                int splitpoint = Partition(arr, first, last, ref changes);
                QuickSortHandler(arr, first, splitpoint - 1, ref changes);
                QuickSortHandler(arr, splitpoint + 1, last, ref changes);
            }
        }

        private static int Partition(int[] arr, int first, int last, ref int changes)
        {
            int pivotValue = arr[first];
            int leftMark = first + 1, rightMark = last;
            bool done = false;
            while (!done)
            {
                while (leftMark <= rightMark && arr[leftMark] < pivotValue) leftMark++;
                while (rightMark >= leftMark && arr[rightMark] > pivotValue) rightMark--;
                if (rightMark < leftMark)
                {
                    done = true;
                }
                else
                {
                    Visualizer.DisplaySwap(arr, leftMark, rightMark, ref changes);
                }
            }
            
            Visualizer.DisplaySwap(arr, first, rightMark, ref changes);
            return rightMark;
        }
    }
}