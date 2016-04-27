using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ConditionalsSlide41_01112016
{
    class Program
    {
        static void Main(string[] args)
        {
            // This example will find the biggest of three integers, using nested if statements

            Console.WriteLine("This program will find the biggest of three integers that you enter.");
            Console.WriteLine();
            Console.Write("Please enter integer #1: ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Please enter integer #2: ");
            int secondInt = int.Parse(Console.ReadLine());
            Console.Write("Please enter integer #3: ");
            int thirdInt = int.Parse(Console.ReadLine());

            int biggest = 0;

            if (firstInt >= secondInt)
            {
                if (firstInt >= thirdInt)
                {
                    biggest = firstInt;
                }
                else
                {
                    biggest = thirdInt;
                }
            }
            else
            {
                if (secondInt >= thirdInt)
                {
                    biggest = secondInt;
                }
                else
                {
                    biggest = thirdInt;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The largest integer is {biggest}.");
        }
    }
}
