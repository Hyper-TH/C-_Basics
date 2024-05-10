using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class Try_Parse
    {
        public static void ShowTryParse()
        {
            bool success = true;
            while (success)
            {
                Console.WriteLine("Enter a number: ");
                string numInput = Console.ReadLine();

                if (int.TryParse(numInput, out int num))
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }

                Console.WriteLine(num);
            }
        }
    }
}
