using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class InOut
    {
        public static void ShowInOut()
        {
            string name;
            int age;
            long lng;
            double dbl;
            float flt;
            decimal dec;

            // WriteLine() => Print it out to the new line
            // Write() => Print it out to the screen
            Console.WriteLine("Hi, my name is Hyper!"); 

            Console.Write("Your name: ");
            name = Console.ReadLine();


            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.WriteLine("Enter a long number: ");
            lng = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter a double ");
            dbl = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a float: ");
            flt = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter a decimal: ");
            dec = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(
                "Your inputs are: \n" +
                "Long: " + lng + "\n" +
                "Double: " + dbl + "\n" +
                "Float: " + flt + "\n" +
                "Decimal: " + dec + "\n" 
            );
        }
    }
}
