using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Conditionals_01112016
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is practice with conditionals
            // if statements and if-else statements

            /*
            Console.Write("How old are you?  ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(age < 17)
            {
                Console.WriteLine("Sorry, you are not old enough to see the movie :(");
            }
            else
            {
                Console.WriteLine("You are old enough to see the movie!");
            }
            */

            /*
            Console.Write("How many pets do you have?  ");
            int numPets = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (numPets == 0)
            {
                Console.WriteLine("No pets? Me neither.");
            }
            else
            {
                Console.WriteLine("Wow! That's a lot of pets.");
            }
            */

            /*
            Console.Write("What is your name?  ");
            string name = Console.ReadLine();
            char firstChar = name[0];
            Console.WriteLine();
            //Console.WriteLine(firstChar);  This was a debugging test to see if the code worked

            if ((firstChar == 'a')||(firstChar == 'A'))
            {
                Console.WriteLine("Your name starts with \"A\". \nYou can go to the front of the line.");

            }
            else
            {
                Console.WriteLine("Sorry, your name does not start with \"A\". \nYou can NOT go to the front of the line.");
            }
            */

            /*
            Console.WriteLine("I'm going to let you know if you can ride this roller coaster.");
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("How many inches tall are you? ");
            double height = double.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("I'm sorry, you are not old enough to ride.");
            }
            if (height < 60)
            {
                Console.WriteLine("Too bad, you are not tall enough to ride.");
            }
            if ((age >= 18) && (height >= 60))
            {
                Console.WriteLine("Congrats!  You are old enough and tall enough to ride.");
            }
            */

            /*
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 16)
            {
                Console.WriteLine("You are old enough to drive.");
                if (age >= 18)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are NOT an adult.");
                }
            }
            else
            {
                Console.WriteLine("You are not an adult and you are not old enough to drive.");
            }
            */

            int score = 0;
            int bonus = 0;
            int totalScore = 0;

            while ((score == 0)||(score > 9))
            {
                Console.Write("Please enter your score (1-9) ");
                score = int.Parse(Console.ReadLine());
                if ((score == 0) || (score > 9))
                {
                    Console.WriteLine("Your score is not within range.");
                }
            }
            if ((score >= 1) && (score <= 3))
            {
                bonus = score * 10;
                totalScore = bonus + score;
            }
            else if ((score >= 4) && (score <= 6)) 
            {
                bonus = score * 100;
                totalScore = bonus + score;
            }
            else if ((score >= 7) && (score <= 9)) 
            {
                bonus = score * 1000;
                totalScore = bonus + score;
            }
            Console.WriteLine("Your score was {0}. You received a bonus of {1}.  Your total score is {2}.", score, bonus, totalScore);

        }
    }
}
