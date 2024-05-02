using System;

namespace MyFirstProject
{
    public static class DataTypes
    {
	    public static void ShowDataTypes()
        {
            int x = 10,
               y = 20,
               z = 30;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // Initialize and Declare
            int age = 23;

            // or
            int age2;
            age2 = 24;

            Console.WriteLine(age);
            Console.WriteLine(age2);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = -900000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // Assignment
            age = 50;

            Console.ReadLine();
        }
    }
}

