using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class IfStatement
    {
        public static void ShowStatements()
        {
            // PART I
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                Console.WriteLine("Valid age!");

                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 25 or older");
                }
            }
            Console.WriteLine("Your name is " + name + " and your age is " + age);

            // PART II

            Console.WriteLine("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);Console.WriteLine("Enter the first number: ");

            Console.WriteLine("Enter the first number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            Console.WriteLine("Value of " + numberA + " x " + numberB + ": ");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (answer == actualAnswer)
            {
                Console.WriteLine("Well done!");
            }
            else 
            {
                Console.WriteLine("Close but it was wrong!");
            }

        }
    }
}
