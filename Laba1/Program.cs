using System;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {


            BankAccount account1 = new BankAccount(); 
            BankAccount account2 = new BankAccount();

            account1.Balance = 1000;
            account2.Balance = 500;

            account1.getMoney(account2, 500);
            Console.WriteLine(account1.Balance);
            account1.getMoney(account2, 500);
            account1.getMoney(account1, 8000);

            Console.WriteLine(account1.Balance);
            Console.ReadKey();




        }
    }
}
