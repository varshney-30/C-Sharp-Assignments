using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 10, 15, 20, 25, 30 };
            int targetValue = 15;

            int index = SearchArray(array, targetValue);

            if (index != -1)
            {
                Console.WriteLine($"The target value {targetValue} was found at index {index+1}.");
            }
            else
            {
                Console.WriteLine($"The target value {targetValue} was not found in the array.");
            }
            Console.ReadKey();
        }

        static int SearchArray(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; // Return the index where the target value was found
                }
            }

            return -1;
        
        }
       
    }
}
