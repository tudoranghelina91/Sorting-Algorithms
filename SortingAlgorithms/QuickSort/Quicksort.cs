using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Quicksort
    {
        static int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while(true)
            {
                while (arr[left] < pivot)
                    left++;

                while (arr[right] > pivot)
                    right--;

                if (left < right)
                {
                    Swap(arr, left, right);
                }

                else
                    return right;
            }
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        static void Swap(int[] arr, int left, int right)
        {
            arr[left] += arr[right];
            arr[right] = arr[left] - arr[right];
            arr[left] -= arr[right];
        }

        static void Print(int[] arr)
        {
            foreach (var i in arr)
                Console.Write($"{i} ");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 1, 0, 4, 7, 3 };
            Print(arr);
            QuickSort(arr, 0, arr.Length - 1);
            Print(arr);
        }
    }
}
