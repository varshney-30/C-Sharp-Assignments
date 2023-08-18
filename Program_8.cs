using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 4, 12, 6, 10, 2 };

            int secondSmallest = FindSecondSmallest(array);

            Console.WriteLine($"The second smallest element in the array is: {secondSmallest}");
            Console.ReadKey();
        }

        static int FindSecondSmallest(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new InvalidOperationException("Array must have at least two elements.");
            }

            SelectionSort(arr);

            return arr[1]; // Return the second element after sorting
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap arr[i] and arr[minIndex]
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }
}
