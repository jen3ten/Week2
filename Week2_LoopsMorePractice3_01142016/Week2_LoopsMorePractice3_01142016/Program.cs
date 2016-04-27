using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_LoopsMorePractice3_01142016
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for an integer.  If it is divisible by 3 write "You Won!"
            //If it isn't divisible by 3 write "You Lost"
            //Keep looping until the user wins.

            Console.WriteLine("Let's play a game.  See if you can win.");

            int userNumber = 1;
            do
            {
                Console.Write("Enter an integer: ");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber % 3 != 0)
                {
                Console.WriteLine("You Lost. Try again.");
                }

            } while (userNumber % 3 != 0);

            Console.WriteLine("Congrats! You won!");
        }
    }
}
