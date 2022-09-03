using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e46
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, p, a;
            int[] arr1 = new int[50];
            
            Console.Write("Input the size of array : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array in ascending order:\n", a);
            for (i = 0; i < a; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nInput the position where to delete: ");
            p = Convert.ToInt32(Console.ReadLine());

            i = 0;
            while (i != p - 1)
                i++;

            while (i < a)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            a--;
            Console.Write("\nThe new list is : ");
            for (i = 0; i < a; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");
        }
    }
}
