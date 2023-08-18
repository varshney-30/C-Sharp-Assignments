using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 2, 8, 2, 7, 5, 1, 3 };

            int[] result = RemoveDuplicates(array);

            Console.WriteLine("Array after removing duplicates:");
            foreach (int num in result)
            {
                Console.Write($"{num} ");
            }

            Console.ReadKey();
        }

        static int[] RemoveDuplicates(int[] arr)
        {
            int length = arr.Length;
            int newSize = 0;

            // Loop through the array and count the number of unique elements
            for (int i = 0; i < length; i++)
            {
                bool isDuplicate = false;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    newSize++;
                }
            }

            // Create a new array without duplicates
            int[] result = new int[newSize];
            int currentIndex = 0;

            // Loop through the array again and populate the new array
            for (int i = 0; i < length; i++)
            {
                bool isDuplicate = false;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    result[currentIndex] = arr[i];
                    currentIndex++;
                }
            }

            return result;
        }
    }
}
