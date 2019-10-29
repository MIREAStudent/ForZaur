using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount acc1 = new BankAccount();
            BankAccount acc2 = new BankAccount(AccountType.Credit);
            BankAccount acc3 = new BankAccount(3000);
            BankAccount acc4 = new BankAccount(AccountType.Credit, 3000);

            acc3.PushAccount(1000);
            acc2.PushAccount(300);
            acc3.GetMoney(acc2, 200); 
            acc3.GetMoney(acc2, 500);
            acc2.PushAccount(1000);

            Console.WriteLine(acc1.Account); 
            Console.WriteLine(acc2.Type); 
            Console.WriteLine(acc3.Balance); 
            Console.WriteLine(acc4.Type + " " + acc4.Balance + " " + acc4.Account ); 

            

            Console.ReadKey(); 

        }
    }
}
