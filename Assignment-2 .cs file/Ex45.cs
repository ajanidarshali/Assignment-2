using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i, a, p, x;

            Console.Write(" Value in the Unsorted Array  \n");

            Console.Write("Input the size of array : ");
            a = Convert.ToInt32(Console.ReadLine());

           ;
            for (i = 0; i < a; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Input the value to be inserted : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted :");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("The current list of the array :\n");
            for (i = 0; i < a; i++)
                Console.Write("{0} ", arr[i]);

            for (i = a; i >= p; i--)
                arr[i] = arr[i - 1];

            arr[p - 1] = x;


            Console.Write("\n\nAfter Insert the element the new list is :\n");
            for (i = 0; i <= a; i++)
                Console.Write("{0} ", arr[i]);
            Console.Write("\n\n");

        }
    }
}
