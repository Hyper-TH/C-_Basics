using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class IsOddEven
    {
        public static void ShowIsOddEven()
        {
            /*
                * Create & initialize two ints
                * Make a variable to work out the remainder
                * Output remainder to the screen
                * Change the first int variable to another number
                  * and recalculate the remainder
                  * output new remainder to the screen
             */

            int firstNum = 10;
            int secondNum = 2;
            int remainder = firstNum % secondNum;

            Console.WriteLine(remainder);    // 10
            Console.WriteLine(secondNum % firstNum);    // 0

            if (remainder == 0)
            {
                Console.WriteLine("Is Even");
            }
            else
            {
                Console.WriteLine("Is Odd");
            }

            firstNum = 25;
            secondNum = 2;
            remainder = firstNum % secondNum;
            Console.WriteLine(remainder);

            if (remainder == 0)
            {
                Console.WriteLine("Is Even");
            }
            else
            {
                Console.WriteLine("Is Odd");
            }
        }
    }
}
