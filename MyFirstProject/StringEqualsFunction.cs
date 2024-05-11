using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class StringEqualsFunction
    {
        public static void ShowStringEquals()
        {
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            } 
            else
            {
                Console.WriteLine("Diff");
            }

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();


            // == will compare reference in memory
            if (!name.Equals(""))
            {
                Console.WriteLine("Your name is " + name);
            }
            else
            {
                Console.WriteLine("Invalid name input");
            }

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);

            // Compare string to an object (check at higher level)
            if (message.Equals(newCompare))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

        }
    }
}
