using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class ConvertingStringToNumbers
    {
        public static void ShowConversion()
        {
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-900000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPrecision = "5.000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textDecimal = "14.99";
            decimal money = Convert.ToDecimal(textDecimal);
            Console.WriteLine(money);

        }
    }
}
