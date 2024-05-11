using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class EmptyString
    {
        public static void ShowEmptyString()
        {
            // Initialize empty string
            // string name;
            // string name = "";
            // string name = string.Empty;

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            if (name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}");

            }
            else
            {
                Console.WriteLine("Name is empty");
            }
        }
    }
}
