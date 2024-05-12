using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class IsStringNullOrEmpty
    {
        public static void ShowIsNullOrEmpty()
        {
            // string name = null;  // This has no content
            string name = "";

            Console.WriteLine($"Your name is {name}");

            if (name != "")
                Console.WriteLine("Has something");

            if (name.Equals(""))
                Console.WriteLine("Is empty");

            if (!name.Equals(""))
                Console.WriteLine("Has something");

            // Doing this is better (with nested checks)
            if (string.IsNullOrEmpty(name))
                Console.WriteLine("Is null/empty");
            
            if (!string.IsNullOrEmpty(name))
                Console.WriteLine("Has something");

        }
    }
}
