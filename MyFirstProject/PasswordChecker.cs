using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class PasswordChecker
    {
        public static void ShowPasswordChecker()
        {
            /*
             * Ask user to enter password, and store
             * Ask user to enter password again, and store
             * Check if they both contain something
                * If so, check if they are the same
                    * If they are, print "Passwords match"
                    * If they are not, print "Passwords do not match"
                * If they are empty, print "Please enter a password."
             */

            string password = "";
            string input = "";

            Console.WriteLine("Start Program");

            Console.WriteLine("Input a new password: ");
            password = Console.ReadLine();

            while (password == "")
            {
                Console.WriteLine("Password must not be empty, try again: ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Password accepted");
            Console.WriteLine("Type password again: ");
            input = Console.ReadLine();

            while (input == "")
            {
                Console.WriteLine("Password must not be empty, try again: ");
                input = Console.ReadLine();
            }

            if (password.Equals(input))
            {
                Console.WriteLine("Passwords match");
            }
            else
            {
                Console.WriteLine("Passwords do not match");
            }


            // Alternative solution
            Console.WriteLine("Enter password: ");
            string passA = Console.ReadLine();

            Console.WriteLine("Enter password again: ");
            string passB = Console.ReadLine();

            if (!passA.Equals(string.Empty))
            {
                if (!passB.Equals(string.Empty))
                {
                    if (password.Equals(passB))
                    {
                        Console.WriteLine("Passwords match");
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password");
            }

            Console.WriteLine("End Program");
        }
    }
}
