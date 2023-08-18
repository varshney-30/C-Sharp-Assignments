using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_5
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
            Console.WriteLine("Reverse of element of array" );
            for (int i = arr.Length-1;i >= 0 ; i--)
            {
                Console.Write(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
