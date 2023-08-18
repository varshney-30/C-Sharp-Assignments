using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter elements for array\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter element " + (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Initial Array");
            
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine("\nEnter any number to multiplication");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Array after multiplicatiion ");
            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i] * p);
            }
            Console.ReadLine();
        }
    }
}
