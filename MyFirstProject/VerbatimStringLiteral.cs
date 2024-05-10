using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class VerbatimStringLiteral
    {
        public static void ShowVerbatimStringLiteral()
        {
            // \t = tab
            // \n  = new line
            // \

            string speech = "He said \"something\"";
            string path = "C:\\COMPSCI_PROJECTS\\c#\\FirstProject\\MyFirstProject\n New line test";

            Console.WriteLine(path);
            Console.WriteLine(speech);

            // Verbatim Identifier
            // $ + 
            // $ + "Your name is {name}"
            // "Your name is " + name

            path = @"C:\COMPSCI_PROJECTS\c#\FirstProject\MyFirstProject" + "\n New line test";
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);
        }
    }
}
