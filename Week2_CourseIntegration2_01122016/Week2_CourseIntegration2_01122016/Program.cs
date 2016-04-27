using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_CourseIntegration2_01122016
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Piggy Bank Counter

            //Ask user for number of pennies, nickles, dimes, quarters, half dollars and gold dollars
            //Print the amount of money in the bank
            //If the bank holds $20 or more, tell the user how many $20 bills they can exchange

            int numCoins = 0;
            double sumMoney = 0.0;

            Console.WriteLine("I will calculate how much money you have in your piggy bank.");
            Console.WriteLine();

            Console.Write("How many pennies do you have? ");
            numCoins = int.Parse(Console.ReadLine());
            sumMoney = (numCoins * 0.01) + sumMoney;

            Console.Write("How many nickels do you have? ");
            numCoins = int.Parse(Console.ReadLine());
            sumMoney = (numCoins * 0.05) + sumMoney;

            Console.Write("How many dimes do you have? ");
            numCoins = int.Parse(Console.ReadLine());
            sumMoney = (numCoins * 0.10) + sumMoney;

            Console.Write("How many quarters do you have? ");
            numCoins = int.Parse(Console.ReadLine());
            sumMoney = (numCoins * 0.25) + sumMoney;

            Console.Write("How many half dollars do you have? ");
            numCoins = int.Parse(Console.ReadLine());
            sumMoney = (numCoins * 0.5) + sumMoney;

            Console.Write("How many gold dollars do you have? ");
            numCoins = int.Parse(Console.ReadLine());
            sumMoney = (numCoins * 1.0) + sumMoney;

            Console.WriteLine();
            Console.WriteLine("You have {0:c2} in the piggy bank.", sumMoney);

            if (sumMoney >= 20.00)
            {
                int num20Bills = Convert.ToInt32(sumMoney) / 20;
                double coinsLeft = sumMoney - (num20Bills * 20);
                Console.WriteLine("Wow! That's a lot of money. You can exchange it for {0} $20 bill(s) \nand still have {1:c2} left over.", num20Bills, coinsLeft);
            }
            else
            {
                double howMuchMore = 20 - sumMoney;
                Console.WriteLine("If you earn {0:c2} more you can get exchange it for a $20 bill!", howMuchMore);
            }

        }
    }
}
