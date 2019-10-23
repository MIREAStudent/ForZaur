using System;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();


            Console.WriteLine(bankAccount.Account);
            BankAccount bankAccount1 = new BankAccount();
            Console.WriteLine(bankAccount1.Account);
            BankAccount bankAccount2 = new BankAccount();
            Console.WriteLine(bankAccount2.Account);

            Console.ReadKey();




        }
    }
}
