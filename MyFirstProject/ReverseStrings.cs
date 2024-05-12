using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyFirstProject
{
    public static class ReverseStrings
    {
        public static void ShowReverseString()
        {
            /*
             * Ask user to input message
             * Print in order
             * Print in reverse
            */

            string input = Console.ReadLine();
            string reverse = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            Console.WriteLine(reverse);

            // or
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            string reversedString = new string(charArray);
            Console.WriteLine(reversedString);

            // Actual excercise
            Console.WriteLine("Printing in reverse order:");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
                Thread.Sleep(500);
            }

            Console.WriteLine("");

            Console.WriteLine("Printing in order:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
                Thread.Sleep(500);

            }
        }
    }
}
