using System;
using System.Collections.Generic;

namespace Day2
{
    // 과제
    class Program6
    {
        static void Main()
        {
            Console.WriteLine("1.");
            int[][] a = {
                new int[] {1,2},
                new int[] {1,2,3},
                new int[] {1,2,3,4}
            };

            int[,] b = new int[3,2] { {1,2}, {3,4}, {5,6} };

            foreach (int[] i in a)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine("\n--------------------");

            foreach (int i in b)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("2.");
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int i=0; i<twoDim.GetLength(0); i++)
            {
                for (int j=0; j<twoDim.GetLength(1); j++)
                {
                    Console.Write(twoDim[i, j]);
                }
            }
            Console.WriteLine();

            foreach (int i in twoDim)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}