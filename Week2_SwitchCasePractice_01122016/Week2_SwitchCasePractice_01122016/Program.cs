using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_SwitchCasePractice_01122016
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practice switch case statements
            // The case statements without a body or break allow the code to drop down to the case 
            // statement below.  Is there a better way to have code execute if one of two or more
            // values occurs?

            string pet = "None";
            Console.Write("What kind of pet do you have? ");
            pet = Console.ReadLine();
            
            switch(pet)     //pet is a string variable; we're going to do something based on the value of pet
            {
                case "Dog": //if pet = "Dog" then drop down and perform next block of code; there is no break
                case "dog": //or if pet = "dog" then perform next block of code
                    Console.WriteLine("You have a dog.  I like cats better.");
                    if (pet == "dog")
                    {
                        Console.WriteLine("You entered 'dog'.");
                    }
                    else
                    {
                        Console.WriteLine("You entered 'Dog'.");
                    }
                    break; //each case statement body needs a break
                case "cat":
                case "Cat":
                    Console.WriteLine("You have a cat.");
                    break;
                case "turtle":
                case "Turtle":
                    Console.WriteLine("Cool! My turtle's name is Smash.");
                    break;
                case "Bunny":
                case "bunny":
                case "rabbit":
                case "Rabbit":
                    Console.WriteLine("You have a bunny.");
                    break;
                case "none":
                case "None":
                    Console.WriteLine("Are you allergic? That's why I don't have any pets.");
                    break;
                default:
                    Console.WriteLine("I don't know what kind of pet you have.");
                    break;
            }

        }
    }
}
