using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_LoopsMorePractice_01142016
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the numbers 1 to n, as long as it is not divisible by both 3 and 7

            Console.WriteLine("I am going to count, but I won't count any number divisible by 3 and 7.");
            Console.Write("What number should I count to? ");
            int countTo = int.Parse(Console.ReadLine());

            for(int i = 1; i <= countTo; i++)
            {
                if(!((i % 3 == 0) && (i % 7 == 0)))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
