using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_CourseIntegration1_01122016
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate a student's GPA on a 4.0 scale.  Take user input.

            Console.WriteLine("If you enter your grades, I will calculate your GPA.");
            Console.Write("How many grades would you like to enter? ");
            int numGrades = int.Parse(Console.ReadLine());
            int sumGrades = 0;

            for (int counter = 1; counter <= numGrades; counter ++)
            {
                Console.Write("Enter grade #" + counter + ": ");
                string gradeLetter = Console.ReadLine();
                switch (gradeLetter)
                {
                    case "a":
                    case "A": sumGrades += 4; break;
                    case "b":
                    case "B": sumGrades += 3; break;
                    case "c":
                    case "C": sumGrades += 2; break;
                    case "d":
                    case "D": sumGrades += 1; break;
                    case "f":
                    case "F": sumGrades += 0; break;
                    default: Console.WriteLine("You did not enter a letter grade."); break;
                }
            }
            Console.WriteLine();
            double GPA = (Convert.ToDouble(sumGrades))/(Convert.ToDouble(numGrades));
            Console.WriteLine("Your GPA is {0:f4}", GPA);
        }
    }
}
