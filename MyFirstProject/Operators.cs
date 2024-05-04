using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class Operators
    {
        public static void ShowOperators()
        {
            // int age = 23;
            double age = 23;

            age++;
            // age = age + 1;
            // age += 1;
            Console.WriteLine(age);

            age--;
            // age = age - 1;
            // age -= 1;
            Console.WriteLine(age);


            age /= 10; // Truncates to 2 => 2.3 -> 2 (so make it double)

            string name = "Hyper";
            name += " Max";
            Console.WriteLine(name);

            // Adds by unicode integer variables
            char ch = 'a';  // Unicode 61
            ch += 'b';  // Unicode 62
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++); // Log before adding
            Console.WriteLine(i);   // Logs sum
            Console.WriteLine(++i); // Adds before logging
        }
    }
}
