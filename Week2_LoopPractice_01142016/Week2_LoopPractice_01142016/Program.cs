using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_LoopPractice_01142016
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Number to the power of
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Raised to what power? ");
            int power = int.Parse(Console.ReadLine());

            int answer = 1;
            for (int counter = 0; counter < power; counter++)
            {
                answer *= num;
            }

            Console.WriteLine($"{num}^{power} = {answer}");
            */

            /*
            //Count from 10 to 1
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            */

            /*
            //sums all odd numbers 1 to n
            //except if number is evenly divisible by 7

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                if(i % 7 == 0)
                {
                    continue;
                }
                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("sum = " + sum);
            */

            /*
            //sum all even numbers, unless the number is evenly divisible by 6
            //print out the sum

            Console.WriteLine("I will sum all even numbers, except those divisible by 6.");
            Console.Write("What number should I count to: ");
            int countTo = int.Parse(Console.ReadLine());
            int sumEvenNot6 = 0;

            for (int i = 0; i <= countTo; i +=2)
            {
                if (i % 6 == 0)
                {
                    continue;
                }
                sumEvenNot6 += i;
            }

            Console.WriteLine($"Sum = {sumEvenNot6}");
            */

            /*
            int i;
            int x;
            for(i = 1; i <=2; i++)          //this loop sets the number of rows
            {
                for(x = 1; x <=4; x++)      //this loop defines what will happen on each line
                {
                    Console.Write(x);       //write numbers 1 through 4 next to each other
                }
                Console.WriteLine();        //return line
            }
            */
            /*

            int n = int.Parse(Console.ReadLine());  //enter a number to count up to
            for (int row = 1; row <= n; row++)      //this loop define how many rows
            {
                for(int col = 1; col <= row; col++) //this loop defines what will happen on each row
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();            //return line
            }
            */

            //Print a 5 x 5 multiplication table

            for (int row = 1; row <=5; row ++)
            {
                for (int col = 1; col <=5; col ++)
                {
                    Console.Write((row * col)+"  ");
                }
                Console.WriteLine();
            }
        }
    }
}
