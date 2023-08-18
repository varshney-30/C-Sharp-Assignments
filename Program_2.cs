using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[5];
            float sum = 0;
            float avg;
            Console.WriteLine("Enter elements for array\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter element " + (i + 1));
                arr[i] = Convert.ToSingle(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg=sum/ arr.Length;
            Console.WriteLine("Average of array is : " + avg);
            Console.ReadLine();
        }
    }
}
