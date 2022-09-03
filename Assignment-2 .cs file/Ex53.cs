using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2e53
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0, a, m = 0;
            int[,] arr1 = new int[50, 50];


            Console.Write("\n\nFind the sum of left diagonals of a matrix : \n\n");


            Console.Write("Input the size of the square matrix : ");
            a = Convert.ToInt32(Console.ReadLine());
            m = a;
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < a; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\n");
            Console.Write("The matrix is :\n");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < a; j++)
                {
                    Console.Write("{0}  ", arr1[i, j]);
                }
                Console.Write("\n");
            }

            for (i = 0; i < a; i++)
            {
                m = m - 1;
                for (j = 0; j < a; j++)
                {
                    if (j == m)
                    {
                        sum = sum + arr1[i, j];
                    }

                }
            }
            Console.Write("Addition of the  left Diagonal elements is :{0}\n", sum);
        }
    }
}
