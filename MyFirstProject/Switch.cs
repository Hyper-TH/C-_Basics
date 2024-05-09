using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class Switch
    {
        public static void ShowSwitch()
        {
            Console.WriteLine("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Mon");
                    break;

                case 2:
                    Console.WriteLine("Tues");
                    break;

                case 3:
                    Console.WriteLine("Wed");
                    break;

                case 4:
                    Console.WriteLine("Thurs");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;

                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}
