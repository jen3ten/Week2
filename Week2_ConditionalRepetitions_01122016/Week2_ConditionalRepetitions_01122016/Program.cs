using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ConditionalRepetitions_01122016
{
    class Program
    {
        static void Main(string[] args)
        {
            // These are if-then repetitions.

            int a = 23;
            int b = 45;
            int c = -20;
            string x = "Jim";
            string y = "Amy";
            string z = "Mike";
            bool D = true;
            bool E = false;

            if(D)
            {
                Console.WriteLine("This is {0}", "boolean D");
                Console.WriteLine(D);
                Console.WriteLine();
            }

            if(D)
            {
                if (c>b)
                {
                    Console.WriteLine("This is {0}", "c > b");
                    Console.WriteLine("{0} and {1}", c, b);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("This is {0}", "c <= b");
                    Console.WriteLine("{0} and {1}", c, b);
                    Console.WriteLine();
                }
            }
            if(x == "Jim")
            {
                Console.WriteLine("This is {0}", "x = Jim");
                Console.WriteLine("{0}", x);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This is {0}", "x <> Jim");
                Console.WriteLine("{0}", x);
                Console.WriteLine();
            }

              
        }
    }
}
