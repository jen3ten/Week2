using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_SwitchExercise2_01122016
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for a digit (0-9)
            // Show the digit as a word
            // Use switch statements

            int digit = -1;
            while ((digit < 0)||(digit > 9))
            {
                Console.Write("Please enter a digit between 0-9: ");
                digit = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            switch(digit)
            {
                case 0: Console.WriteLine("This is a zero."); break;
                case 1: Console.WriteLine("This is number one."); break;
                case 2: Console.WriteLine("This is number two."); break;
                case 3: Console.WriteLine("This is number three."); break;
                case 4: Console.WriteLine("This is number four."); break;
                case 5: Console.WriteLine("This is number five."); break;
                case 6: Console.WriteLine("This is number six."); break;
                case 7: Console.WriteLine("This is number seven."); break;
                case 8: Console.WriteLine("This is number eight."); break;
                case 9: Console.WriteLine("This is number nine."); break;
            }

        }
    }
}
