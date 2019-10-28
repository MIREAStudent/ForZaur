using System;
using System.Text;

namespace Laba1
{
    class BankAccount
    {
        private int account;
        static private int globalAccount = 1000;
        private int balance;
        private AccountType type;

        public int Account { get => account;  }
        public static int GlobalAccount { get => globalAccount;  }
        public int Balance { get => balance; }
        internal AccountType Type { get => type; }

        public BankAccount()
        {
            incGlobalAccount();
        }

        public BankAccount(AccountType type)
        {
            this.type = type; 
            incGlobalAccount();
        }

        public BankAccount(int balance)
        {
            this.balance = balance;
            incGlobalAccount();
        }

        public BankAccount(AccountType type, int balance)
        {
            this.type = type;
            this.balance = balance;
            incGlobalAccount();
        }

        private void incGlobalAccount()
        {
            this.account = globalAccount; 
            globalAccount += 10;
        }

        public void pullAccount(int sum)
        {
            if (this.balance > sum)
                this.balance -= sum;
            else
                Console.WriteLine("Недостаточно средств");
        }

        public void pushAccount(int sum)
        {
            this.balance += sum;
        }

        public void getMoney(BankAccount account, int money)
        {
            if (account != this)
            {
                if (account.balance >= money)
                {
                    account.balance -= money;
                    this.balance += money;

                }
                else
                {
                    Console.WriteLine("Недостаточно средств для перевода");
                }
            }
            else
            {
                Console.WriteLine("Попытка перевести средтсва самому себе");
            }

        }


    }


}
