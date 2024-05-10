using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class TimesTable
    {
        public static void ShowTimesTable()
        {
            /*
             * Ask the user for a number for the table
             * Write a for loop to print X times table
            */

            string numInput;
            int num;

            Console.WriteLine("Enter a number: ");
            numInput = Console.ReadLine();

            while (!(int.TryParse(numInput, out num)))
            {
                Console.WriteLine("Not a valid number, please input again: ");
                numInput = Console.ReadLine();
            }

            Console.WriteLine("Initiating times table now..");

            for (int i = 0; i < 13; i++) 
            {
                Console.WriteLine("{0} x {1} = {2}", i, num, i * num);
            }

            Console.WriteLine("End Program");
        }
    }
}
