using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_CodeEvalComparePoints_01122016
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "0 1 0 5";  //this is the input sample in code eval
            string[] splitLine = line.Split(new char[] {' '}); //splits the original string (char array) into
            // small strings in a second string array

            int xGroup = int.Parse(splitLine[0]);   //assign integer variables to hold the indexes of the array
            int yGroup = int.Parse(splitLine[1]);
            int xOverlook = int.Parse(splitLine[2]);
            int yOverlook = int.Parse(splitLine[3]);

            int xDiff = xOverlook - xGroup;     //calculate the difference between the x coordinates
            int yDiff = yOverlook - yGroup;     //calculate the difference between the y coordinates

            if (xDiff > 0)          //series of nested if-else-if statements that define direction
            {
                if (yDiff > 0)
                {
                    Console.WriteLine("NE");
                }
                else if (yDiff < 0)
                {
                    Console.WriteLine("SE");
                }
                else
                {
                    Console.WriteLine("E");
                }
            }
            else if (xDiff < 0)
            {
                if (yDiff > 0)
                {
                    Console.WriteLine("NW");
                }
                else if (yDiff < 0)
                {
                    Console.WriteLine("SW");
                }
                else
                {
                    Console.WriteLine("W");
                }
            }
            else
            {
                if (yDiff > 0)
                {
                    Console.WriteLine("N");
                }
                else if (yDiff < 0)
                {
                    Console.WriteLine("S");
                }
                else
                {
                    Console.WriteLine("here");
                }
            }
        }
    }
}
