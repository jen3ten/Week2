using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_SwitchCaseWarmUp_01132016
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// #1
            // Switch statement to test for user input values of 1 or 3.
            // Write "1" for "1" and "3" for "3", otherwise "That's not a 1 or 3."

            Console.Write("Please enter a number.  I will tell you if it is a 1 or 3.  ");
            string numberInput = Console.ReadLine();

            // Use switch case statement to test values of numberInput

            switch(numberInput)
            {
                case "1":
                    Console.WriteLine("You entered number 1.");
                    break;
                case "3":
                    Console.WriteLine("You entered number 3.");
                    break;
                default:
                    Console.WriteLine("That's not a 1 or 3.");
                    break;
            }
            */

            // #2
            // Use switch statement to catch number values
            // If 1, 2, 3 write "Low int"
            // If 4, 5, 6 write "Med int"
            // If 7, 8, 9 write "High int"
            // Default write "Does not compute"

            Console.Write("Please enter a number between 1 and 9: ");
            //int numberValue = int.Parse(Console.ReadLine());          Testing various types of code
            int numberValue = Convert.ToInt32(Console.ReadLine());

            switch(numberValue)
            {
                case 1:
                case 2:
                case 3: Console.WriteLine("Low int"); break;
                case 4:
                case 5:
                case 6: Console.WriteLine("Med int"); break;
                case 7:
                case 8:
                case 9: Console.WriteLine("High int"); break;
                default: Console.WriteLine("Does not compute."); break;
            }
        }
    }
}
