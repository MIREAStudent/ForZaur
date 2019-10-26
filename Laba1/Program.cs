using System;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {

            ChekSystemIFormattable chekSystemIFormattable = new ChekSystemIFormattable();

            

            Console.WriteLine(Instanceof.Instance(chekSystemIFormattable)); 
            Console.WriteLine(Instanceof.Instance(new Object())); 


            Console.ReadKey();




        }
    }
}
