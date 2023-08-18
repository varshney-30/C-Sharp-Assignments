using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 7, 2, 8, 5 };
            int[] array2 = { 8, 2, 7, 1, 6 };

            int[] commonElements = FindCommonElements(array1, array2);

            Console.WriteLine("Common elements between the two arrays:");
            foreach (int num in commonElements)
            {
                Console.Write($"{num} ");
            }


            Console.ReadKey();
        }

        static int[] FindCommonElements(int[] arr1, int[] arr2)
        {
            int length1 = arr1.Length;
            int length2 = arr2.Length;

            int maxSize = Math.Max(length1, length2);

            int[] common = new int[maxSize];
            int commonIndex = 0;

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        common[commonIndex] = arr1[i];
                        commonIndex++;
                        break;
                    }
                }
            }

            int[] result = new int[commonIndex];
            Array.Copy(common, result, commonIndex);

            return result;
        }
    }
}
