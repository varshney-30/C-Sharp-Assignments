using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[5];
            float largest = 0;
           
            Console.WriteLine("Enter elements for array\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter element " + (i + 1));
                arr[i] = Convert.ToSingle(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (largest < arr[i])
                {
                    largest = arr[i];
                }
                //else largest = arr[i + 1];
            }

            Console.WriteLine("Largest element of array is : " + largest);
            Console.ReadLine();
        }
    }
}
