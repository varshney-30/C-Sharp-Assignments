using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find the sum of all elements in an integer array using a loop
            int[] arr = new int[10];
            int sum = 0;
            Console.WriteLine("Enter elements for array\n");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter element " + (i + 1));
                arr[i] = Convert.ToInt32( Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("sum of array is : " + sum);
            Console.ReadLine();
        }
    }
}
