using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class IfStatement
    {
        public static void ShowStatements()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            /*
            if (age >= 18 && age <= 25)
            {
                Console.WriteLine("You are between 18 and 25");
            } 
            else if (age >= 26)
            {
                Console.WriteLine("You are 25 or older");
            }
            */

            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);
        }
    }
}
