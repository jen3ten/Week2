using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_LoopsMorePractice2_01142016
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints a matrix of numbers
            // 1 2 3 4
            // 2 3 4 5
            // 3 4 5 6
            // 4 5 6 7

            /* Method 1
            for (int row = 1; row <= 4; row ++)
            {
                for (int col = row; col <= (row + 3); col ++)
                {
                    Console.Write(col+ " ");
                }
                Console.WriteLine();
            }
            */

            // Method 2
            for (int row = 0; row < 4; row++)
            {
                for (int col = 1; col <= 4; col++)
                {
                    Console.Write((col + row) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
