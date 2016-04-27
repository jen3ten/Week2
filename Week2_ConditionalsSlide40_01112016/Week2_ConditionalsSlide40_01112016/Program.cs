using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ConditionalsSlide40_01112016
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an if statement that takes 2 variables and exchanges their values if
            // the first one is greater than the second one

            Console.WriteLine("I will ask you to enter 2 whole numbers.\nIf the first one is greater than the second one I will exchange their values.");
            Console.WriteLine();
            Console.Write("Please enter the first whole number: ");
            int firstVariable = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second whole number: ");
            int secondVariable = int.Parse(Console.ReadLine());

            if (firstVariable > secondVariable)
            {
                int newFirstVariable = secondVariable;
                int newSecondVariable = firstVariable;
                Console.WriteLine($"You entered numbers {newFirstVariable} and {newSecondVariable}.");
            }
            else if (secondVariable > firstVariable)
            {
                Console.WriteLine($"You entered numbers {firstVariable} and {secondVariable}.");
            }
            else
            {
                Console.WriteLine($"You entered numbers {firstVariable} and {secondVariable}.");
                Console.WriteLine("These numbers are the same.");
            }

        }
    }
}
