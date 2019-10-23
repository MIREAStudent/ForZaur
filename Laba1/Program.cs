using System;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Account = 1;
            bankAccount.Balance = 0;
            bankAccount.Type = AccountType.Debet;

            Console.ReadKey();




        }
    }
}
