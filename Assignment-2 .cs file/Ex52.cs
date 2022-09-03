using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e52
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, r1, c1, r2, c2, sum = 0;

            int[,] arr1 = new int[50, 50];
            int[,] arr2= new int[50, 50];
            int[,] arr3 = new int[50, 50];

            Console.Write("\n\nMultiplication of two Matrices : ");


            Console.Write("\nInput the number of rows and columns of the first matrix :\n");
            Console.Write("Rows : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput the number of rows of the second matrix :\n");
            Console.Write("Rows : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            if (c1 != r2)
            {
                Console.Write("Mutiplication of Matrix is not possible.");
                Console.Write("\nColumn of first matrix and row of second matrix must be same.");
            }
            else
            {
                Console.Write("Input elements in the first matrix :\n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("Input elements in the second matrix :\n");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("\nThe First matrix is :\n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c1; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }

                Console.Write("\nThe Second matrix is :\n");
                for (i = 0; i < r2; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                        Console.Write("{0}\t", arr2[i, j]);
                }

                for (i = 0; i < r1; i++)
                    for (j = 0; j < c2; j++)
                        arr3[i, j] = 0;
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        sum = 0;
                        for (k = 0; k < c1; k++)
                            sum = sum + arr1[i, k] * arr2[k, j];
                        arr3[i, j] = sum;
                    }
                }
                Console.Write("\nThe multiplication of two matrix is : \n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("{0}\t", arr3[i, j]);
                    }
                }
            }
            Console.Write("\n\n");
        }
    }
}
