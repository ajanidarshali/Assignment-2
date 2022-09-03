using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e51
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, a;
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] arr3 = new int[50, 50];

            Console.Write("\n\nSubtraction of two Matrices : ");

            Console.Write("Input the size of the square matrix (less than 5): ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < a; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < a; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe First matrix is :\n");
            for (i = 0; i < a; i++)
            {
                Console.Write("\n");
                for (j = 0; j < a; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            Console.Write("\nThe Second matrix is :\n");
            for (i = 0; i < a; i++)
            {
                Console.Write("\n");
                for (j = 0; j < a; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }

            for (i = 0; i < a; i++)
            {
                for (j = 0; j < a; j++)
                {
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
                }
            }
            Console.Write("\nThe Subtraction of two matrix is : \n");
            for (i = 0; i < a; i++)
            {
                Console.Write("\n");
                for (j = 0; j < a; j++)
                {
                    Console.Write("{0}\t", arr3[i, j]);
                }
            }
            Console.Write("\n\n");
        }
    }
}
