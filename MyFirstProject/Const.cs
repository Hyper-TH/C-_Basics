using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public static class Const
    {
        public static void ShowConst()
        {
            const string version = "v1.0";
            const int vat = 20;
            const double percentVAT = vat / 100D;
            // vat = 10;

            int balance = 1000;

            Console.WriteLine(version);
            Console.WriteLine(vat);
            Console.WriteLine(balance * percentVAT); ;

            
        }
    }
}
