using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyFirstProject
{
    public static class StringIteration
    {
        public static void ShowStringIteration()
        {
            string message = "C# is awesome";
            // char[]
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[3]);
            Console.WriteLine(message[4]);
            Console.WriteLine(message[5]);

            for (int i = 0; i < message.Length; i++) 
            {
                Console.Write(message[i]);
                Thread.Sleep(50); // 1000ms = 1s
            }

            Console.WriteLine(message.Contains("C"));

            bool contains = false;

            for (int i = 0;i < message.Length; i++)
            {
                if (message[i] == 'C')
                {
                    contains = true;
                    break;
                }
            }

            Console.WriteLine(contains);
        }
    }
}
