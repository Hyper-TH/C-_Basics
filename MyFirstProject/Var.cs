using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class Var
    {
        public static void ShowVar()
        {
            // int age = -23;
            var age = -23;
            Console.WriteLine(age);

            // long bigNumber = -900000000L;
            var bigNumber = -900000000L;
            Console.WriteLine(bigNumber);

            // float precision = 5.000001F;
            var precision = 5.000001F;
            Console.WriteLine(precision);

            // decimal money = 14.99M;
            var money = 14.99M;
            Console.WriteLine(money);

            var name = "Hyper";
            var letter = 'a';
            Console.WriteLine(name);
            Console.WriteLine(letter);
        }
    }
}
