using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MyFirstProject
{
    public static class NumericFormatting
    {
        public static void ShowNumericFormatting()
        {
            double value = 1000D / 12.34;

            Console.WriteLine(value);

            // {0} : Represents the first value of the list
            // {1} : Represents the second value of the list
            // {0:00} : Round the first value by 2 decimal places (does not affect value, only by printing)
            Console.WriteLine(string.Format("{0:0.00} {1}", value, 1000));

            // Trim off any trailing 0s
            Console.WriteLine(string.Format("{0:0.#}", value));

            double money = -10D / 3D; // 3.33333
            Console.WriteLine(string.Format("-£10 / £3 = £{0:0.00}", money));

            // Display Currency (based on OS location)
            Console.WriteLine(money.ToString("C"));     // Native form
            Console.WriteLine(money.ToString("C0"));    // Whole number
            Console.WriteLine(money.ToString("C1"));    // By 1
            Console.WriteLine(money.ToString("C2"));    // By 2

            Console.WriteLine(money.ToString("C", 
                CultureInfo.CurrentCulture));

            Console.WriteLine(money.ToString("C", 
                CultureInfo.CreateSpecificCulture("en-GB")));
            
            Console.WriteLine(money.ToString("C", 
                CultureInfo.CreateSpecificCulture("en-US")));

            Console.WriteLine(money.ToString("C",
                CultureInfo.CreateSpecificCulture("en-AU")));
        }
    }
}
