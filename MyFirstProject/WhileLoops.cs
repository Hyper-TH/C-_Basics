using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class WhileLoops
    {
        public static void ShowWhileLoops()
        {
            Random rnd = new Random();

            int guessNum;
            int randNum = rnd.Next(1,11);
            string prompt = "Input a number: ";

            Console.WriteLine(randNum);

            Console.WriteLine(prompt);
            
            guessNum = Convert.ToInt32(Console.ReadLine());

            while (guessNum != randNum)
            {
                Console.WriteLine("Incorrect number, try again: ");
                Console.WriteLine(prompt);

                guessNum = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("You guessed correctly");

            // Actual Lesson
            int i = 0;
            int j = 10;
            
            // While loops will check first
            while (i < 10) 
            {
                i++;
                Console.WriteLine(i);

                // i++
            }

            // Do While will always happen once (i.e., check condition at the end
            do
            {
                Console.WriteLine(i);
            } while (j != 10);

            Console.WriteLine("End Program");
        }
    }
}
