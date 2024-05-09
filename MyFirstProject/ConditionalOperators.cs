using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class ConditionalOperators
    {
        public static void ShowConditionalOperators()
        {
            int age = -10;

            // condition ? true : false
            string result = age >= 0 ? "Valid" : "Invalid";
            // Console.WriteLine(age >= 0 ? "Valid" : "Invalid");   // Better for memory

            Console.WriteLine(result);
        }
    }
}
