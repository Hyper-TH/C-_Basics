using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyFirstProject
{
    public static class ForLoops
    {
        public static void ShowForLoops()
        {
            const int length = 10;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Hello World: " + i);
            }

            Console.WriteLine("What do you want to repeat: ");
            string message = Console.ReadLine();

            Console.WriteLine("How many times repeated *2: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Please enter a value above 0");
            }
            else
            {
                for (int i = 0; i <= loopCounter; i += 2)
                {
                    Console.WriteLine(message + ":" + i);
                }
            }
        }
    }
}
