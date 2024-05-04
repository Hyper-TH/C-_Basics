using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class Remainder
    {
        public static void ShowRemainder()
        {
            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum / secondNum);    // Truncates
            Console.WriteLine(firstNum % secondNum);    // Gives remainder
        }
    }
}
