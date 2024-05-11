using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class StringInterpolation
    {
        public static void ShowStringInterpolation()
        {
            string name = "Aba";
            int age = 23;

            Console.WriteLine("Your name is " + name + " your age is " + age);
            Console.WriteLine($"Your name is {name} your age is {age}");
        }
    }
}
