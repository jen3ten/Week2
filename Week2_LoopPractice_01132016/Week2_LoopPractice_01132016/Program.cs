using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_LoopPractice_01132016
{
    class Program
    {
        static void Main(string[] args)
        {
            /* #1
            int counter = 0;                    //The Initializer
            while(counter <= 10)                //The Condition
            {
                Console.WriteLine(counter);     //The Loop Body
                counter += 2;                   //The Updater
            }
            */

            /* #2
            //Sum numbers from 1 to 10 and print result
       
            int sum = 0;
            int counter = 1;                //The Initializer starts at 1, it is also the number we are adding

            while(counter <=10)             //The Condition includes 10
            {
                Console.WriteLine(counter); //Anything printed to the screen here prints in every loop
                sum += counter;             //Same as sum = sum + counter
                counter++;
            }
            Console.WriteLine($"The sum of these numbers is {sum}");
            */

            
            /* #3
            // Ask a user to enter a starting number and an ending number.
            // Count and print every number from low to high
            // Then modified to multiply all the numbers in the range

            //Console.WriteLine("I am going to count for you.");
            Console.WriteLine("I am going to multiply numbers for you.");

            Console.Write("Please enter a starting number: ");
            int startNum = int.Parse(Console.ReadLine());
            //int endNum = -1000;  //I think I could eliminate this with a do-while loop
            int maxTries = 0;
            decimal product = 1;
            int endNum;

            do
            {
                Console.Write($"Please enter an ending number that is bigger than {startNum}: ");
                endNum = int.Parse(Console.ReadLine());
                maxTries++;
                if (maxTries == 5)
                {
                    Console.WriteLine("You have reached your maximum number of tries.");
                    Console.WriteLine($"Let's use {startNum + 5} as the ending number.");
                    endNum = startNum + 5;
                    break;
                }
            } while (startNum >= endNum);
            int originalStartNum = startNum;

            do
            {
                product *= startNum;
                //Console.WriteLine(startNum);
                startNum++;
            } while (startNum <= endNum);
            Console.WriteLine($"The product of the numbers from {originalStartNum} to {endNum} is {product}.");
            */

            /* #4
            // What happens if you put a break inside of nested while loops?
            // It only breaks out of the inner while loop

            int counter = 0;
            while (true)
            {
                while (counter < 10)
                {
                    if (counter==2)
                    {
                        break;
                    }
                    counter++;
                }
                Console.WriteLine(counter);
                //break;
            }
            */

            // #5 Factorials
            // Calculate the factorial of a number, which is 5! = 5 * 4 * 3 * 2 * 1
            // Have the user enter the starting number

            decimal factorial = 1;
            Console.WriteLine("I will calculate the factorial of a number you enter.");
            int userNumber = 0;

            do
            {
                Console.Write("Please enter a positive number between 1 and 20: ");
                userNumber = int.Parse(Console.ReadLine());
            } while ((userNumber < 1)||(userNumber > 20));

            int originalUserNumber = userNumber;       //Remember the original number so we can reference later

            do
            {
                factorial *= userNumber;
                userNumber --;
            } while (userNumber > 1);

            Console.WriteLine($"{originalUserNumber}! = {factorial}.");

            

            /*#6 Count from 1 to 10
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */
        }
    }
}
