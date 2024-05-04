using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            // System.Console.WriteLine("Hello World");

            DataTypes.ShowDataTypes();
            String_Chars.ShowStringChars();
            ConvertingStringToNumbers.ShowConversion();
            BooleanDataType.ShowBool();
            Operators.ShowOperators();
            Remainder.ShowRemainder();

            Console.ReadLine();
        }
    }
}
