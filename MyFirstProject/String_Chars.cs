using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class String_Chars
    {
        public static void ShowStringChars()
        {
            string name = "Hyper";      // Has to be in double quotes
            string empty = "";          // Empty String
            char letter = 'a';          // Has to be in single quotes
            char defaultChar = '\0';  

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Here is the letter: " + letter);
        }
    }
}
