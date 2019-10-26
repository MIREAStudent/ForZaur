using System;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {



            MailFile mailFile = new MailFile();

            mailFile.MailSet("C:\\Лабы CSharp\\Laba1\\users.txt"); 



            Console.ReadKey();




        }
    }
}
