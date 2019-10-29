using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {

            ACipher elem = new ACipher();


            Console.WriteLine(elem.Enecode("абв?гд !"));
            Console.WriteLine(elem.Decode("ааа яяя ббб ввв ! ?"));
            

            Console.ReadKey(); 

        }
    }
}
